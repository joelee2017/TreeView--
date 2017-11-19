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

namespace FrmMyAlum練習17111914
{
    public partial class Form1 : Form
    {
        public Form1()
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
                sqlText = @"select 
                                Id, 
                                Photo 
                            from 
                                PhotoTable;";
            }
            else
            {
                sqlText = @"select 
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

    }
}   
