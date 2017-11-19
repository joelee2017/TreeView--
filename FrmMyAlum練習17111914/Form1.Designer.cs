namespace FrmMyAlum練習17111914
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.lstPhotoType = new System.Windows.Forms.ListBox();
            this.lstPhoto = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(996, 644);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnClear);
            this.tabPage1.Controls.Add(this.BtnDelete);
            this.tabPage1.Controls.Add(this.BtnInsert);
            this.tabPage1.Controls.Add(this.BtnOpenFile);
            this.tabPage1.Controls.Add(this.BtnLoad);
            this.tabPage1.Controls.Add(this.lstPhotoType);
            this.tabPage1.Controls.Add(this.lstPhoto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(988, 618);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(825, 494);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 7;
            this.BtnClear.Text = "取消";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(731, 536);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "刪除";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(731, 494);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 5;
            this.BtnInsert.Text = "新增";
            this.BtnInsert.UseVisualStyleBackColor = true;
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Location = new System.Drawing.Point(731, 451);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.BtnOpenFile.TabIndex = 4;
            this.BtnOpenFile.Text = "檔案";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(731, 411);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 3;
            this.BtnLoad.Text = "讀取";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // lstPhotoType
            // 
            this.lstPhotoType.FormattingEnabled = true;
            this.lstPhotoType.ItemHeight = 12;
            this.lstPhotoType.Location = new System.Drawing.Point(3, 19);
            this.lstPhotoType.Name = "lstPhotoType";
            this.lstPhotoType.Size = new System.Drawing.Size(183, 556);
            this.lstPhotoType.TabIndex = 2;
            this.lstPhotoType.SelectedIndexChanged += new System.EventHandler(this.lstPhotoType_SelectedIndexChanged);
            // 
            // lstPhoto
            // 
            this.lstPhoto.Location = new System.Drawing.Point(192, 19);
            this.lstPhoto.Name = "lstPhoto";
            this.lstPhoto.Size = new System.Drawing.Size(504, 556);
            this.lstPhoto.TabIndex = 1;
            this.lstPhoto.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(988, 618);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 644);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.ListBox lstPhotoType;
        private System.Windows.Forms.ListView lstPhoto;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

