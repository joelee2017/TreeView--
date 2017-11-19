using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrmMyAlum練習17111914.Properties;
using System.IO;
using System.Drawing.Imaging;

namespace FrmMyAlum練習17111914
{
    public partial class FrmMyAlum : Form
    {
        public FrmMyAlum()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using (var cn = new SqlConnection(Settings.Default.Photo))
            using (var adp = new SqlDataAdapter(@"
                  SELECT DISTINCT
                    phototype
                  FROM
                    phototable;", cn))
            {
                var dt = new DataTable();

                adp.Fill(dt);

                var allRow = dt.NewRow();
                allRow["PhotoType"] = "全部";

                dt.Rows.InsertAt(allRow, 0);

                lstPhotoType.DataSource = dt;
            }
        }

        private void lstPhotoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var photoType = (string)lstPhotoType.SelectedValue;

            var sqlText = string.Empty;

            if (photoType == "全部")
            {
                sqlText = @"
                            select 
                                Id, 
                                Photo 
                            from 
                                PhotoTable;";
            }
            else
            {
                sqlText = @"
                            select 
                                Id, 
                                Photo 
                            from 
                                PhotoTable
                            where
                                PhotoType =@type;";

            }

            using (var cn = new SqlConnection(Settings.Default.Photo))
            using (var adp = new SqlDataAdapter(sqlText, cn))
            {
                adp.SelectCommand.Parameters.Add("type", SqlDbType.NVarChar).Value = photoType;
                var dt = new DataTable();
                adp.Fill(dt);
                var imgList = new ImageList();
                imgList.ImageSize = new Size(100, 100);
                lstPhoto.LargeImageList = imgList;
                lstPhoto.Items.Clear();

                var imgs = from row in dt.AsEnumerable()
                           select new
                           {
                               Id = row.Field<int>("Id").ToString(),
                               Pic = Image.FromStream(new MemoryStream(row.Field<byte[]>("Photo")))
                           };
                foreach(var item in imgs)
                {
                    imgList.Images.Add(item.Id, item.Pic);
                    var lisItem = lstPhoto.Items.Add(item.Id);
                    lisItem.ImageKey = item.Id;
                }

            }
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() ==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromStream(openFileDialog1.OpenFile());
                textName.Text = openFileDialog1.SafeFileName;
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            using (var cn = new SqlConnection(Settings.Default.Photo))
            using (var cmd = new SqlCommand(@"
                    INSERT INTO PhotoTable(PhotoDesc, 
                                            PhotoDate,
                                            PhotoType,
                                            Photo)
                                Values(@fileNAME,
                                       @date,
                                       @type,
                                       @photo);", cn))
            {
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("fileName", SqlDbType.NVarChar).Value = textName.Text;
                cmd.Parameters.Add("type", SqlDbType.NVarChar).Value = textType.Text;
                cmd.Parameters.Add("date", SqlDbType.DateTime).Value = dateTimePicker1.Text;

                using (var ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, ImageFormat.Png);
                    cmd.Parameters.Add("photo", SqlDbType.VarBinary).Value = ms.ToArray();

                }
                cn.Open();

                MessageBox.Show("ok");
                cmd.ExecuteNonQuery();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var selectItem = lstPhoto.SelectedItems.Cast<ListViewItem>().First();
            var selectedID = int.Parse(selectItem.Text);

            using (var cn = new SqlConnection(Settings.Default.Photo))
            using (var cmd = new SqlCommand(@"
                                DELETE PhotoTable
                                where
                                     Id =@id", cn))
            {
                cmd.Parameters.Add("id", SqlDbType.Int).Value = selectedID;

                cn.Open();
                cmd.ExecuteNonQuery();
            }
                            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.textName.Text = "";
            this.textType.Text = "";
            this.pictureBox1.Image = null;
        }
    }
}   
