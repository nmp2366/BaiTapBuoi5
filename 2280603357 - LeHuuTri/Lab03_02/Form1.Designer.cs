namespace Lab03_02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            rtbVanBan = new RichTextBox();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            tạoVănBảnMớiToolStripMenuItem = new ToolStripMenuItem();
            mởTậpTinToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            lưuNộiDungVănBảnToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            địnhDạngToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btn_TaoFileMoi = new ToolStripButton();
            btn_luuFile = new ToolStripButton();
            cmbFont = new ToolStripComboBox();
            toolStripSeparator2 = new ToolStripSeparator();
            cmbsize = new ToolStripComboBox();
            toolStripSeparator3 = new ToolStripSeparator();
            btn_indam = new ToolStripButton();
            btn_innghien = new ToolStripButton();
            btn_gacchchan = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // rtbVanBan
            // 
            rtbVanBan.Location = new Point(12, 87);
            rtbVanBan.Name = "rtbVanBan";
            rtbVanBan.Size = new Size(750, 317);
            rtbVanBan.TabIndex = 0;
            rtbVanBan.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, địnhDạngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tạoVănBảnMớiToolStripMenuItem, mởTậpTinToolStripMenuItem, toolStripSeparator1, lưuNộiDungVănBảnToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(93, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // tạoVănBảnMớiToolStripMenuItem
            // 
            tạoVănBảnMớiToolStripMenuItem.Name = "tạoVănBảnMớiToolStripMenuItem";
            tạoVănBảnMớiToolStripMenuItem.Size = new Size(250, 26);
            tạoVănBảnMớiToolStripMenuItem.Text = "Tạo Văn Bản Mới";
            tạoVănBảnMớiToolStripMenuItem.Click += tạoVănBảnMớiToolStripMenuItem_Click;
            // 
            // mởTậpTinToolStripMenuItem
            // 
            mởTậpTinToolStripMenuItem.Name = "mởTậpTinToolStripMenuItem";
            mởTậpTinToolStripMenuItem.Size = new Size(250, 26);
            mởTậpTinToolStripMenuItem.Text = "Mở Tập Tin";
            mởTậpTinToolStripMenuItem.Click += mởTậpTinToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(247, 6);
            // 
            // lưuNộiDungVănBảnToolStripMenuItem
            // 
            lưuNộiDungVănBảnToolStripMenuItem.Name = "lưuNộiDungVănBảnToolStripMenuItem";
            lưuNộiDungVănBảnToolStripMenuItem.Size = new Size(250, 26);
            lưuNộiDungVănBảnToolStripMenuItem.Text = "Lưu Nội Dung Văn Bản";
            lưuNộiDungVănBảnToolStripMenuItem.Click += lưuNộiDungVănBảnToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(250, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // địnhDạngToolStripMenuItem
            // 
            địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            địnhDạngToolStripMenuItem.Size = new Size(97, 24);
            địnhDạngToolStripMenuItem.Text = "Định Dạng";
            địnhDạngToolStripMenuItem.Click += địnhDạngToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_TaoFileMoi, btn_luuFile, cmbFont, toolStripSeparator2, cmbsize, toolStripSeparator3, btn_indam, btn_innghien, btn_gacchchan });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 28);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_TaoFileMoi
            // 
            btn_TaoFileMoi.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_TaoFileMoi.Image = (Image)resources.GetObject("btn_TaoFileMoi.Image");
            btn_TaoFileMoi.ImageTransparentColor = Color.Magenta;
            btn_TaoFileMoi.Name = "btn_TaoFileMoi";
            btn_TaoFileMoi.Size = new Size(29, 25);
            btn_TaoFileMoi.Text = "toolStripButton1";
            btn_TaoFileMoi.Click += btn_TaoFileMoi_Click;
            // 
            // btn_luuFile
            // 
            btn_luuFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_luuFile.Image = (Image)resources.GetObject("btn_luuFile.Image");
            btn_luuFile.ImageTransparentColor = Color.Magenta;
            btn_luuFile.Name = "btn_luuFile";
            btn_luuFile.Size = new Size(29, 25);
            btn_luuFile.Text = "toolStripButton2";
            btn_luuFile.Click += btn_luuFile_Click;
            // 
            // cmbFont
            // 
            cmbFont.Items.AddRange(new object[] { "Tahoma" });
            cmbFont.Name = "cmbFont";
            cmbFont.Size = new Size(121, 28);
            cmbFont.Click += loadfont_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // cmbsize
            // 
            cmbsize.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "13", "14", "15", "16", "18", "20", "22", "24", "26", "28", "30", "36", "48", "72" });
            cmbsize.Name = "cmbsize";
            cmbsize.Size = new Size(121, 28);
            cmbsize.Click += loadsize_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 28);
            // 
            // btn_indam
            // 
            btn_indam.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_indam.Image = (Image)resources.GetObject("btn_indam.Image");
            btn_indam.ImageTransparentColor = Color.Magenta;
            btn_indam.Name = "btn_indam";
            btn_indam.Size = new Size(29, 25);
            btn_indam.Text = "toolStripButton3";
            btn_indam.Click += btn_indam_Click;
            // 
            // btn_innghien
            // 
            btn_innghien.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_innghien.Image = (Image)resources.GetObject("btn_innghien.Image");
            btn_innghien.ImageTransparentColor = Color.Magenta;
            btn_innghien.Name = "btn_innghien";
            btn_innghien.Size = new Size(29, 25);
            btn_innghien.Text = "toolStripButton4";
            btn_innghien.Click += btn_innghien_Click;
            // 
            // btn_gacchchan
            // 
            btn_gacchchan.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_gacchchan.Image = (Image)resources.GetObject("btn_gacchchan.Image");
            btn_gacchchan.ImageTransparentColor = Color.Magenta;
            btn_gacchchan.Name = "btn_gacchchan";
            btn_gacchchan.Size = new Size(29, 25);
            btn_gacchchan.Text = "toolStripButton5";
            btn_gacchchan.Click += btn_gacchchan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(rtbVanBan);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbVanBan;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem tạoVănBảnMớiToolStripMenuItem;
        private ToolStripMenuItem mởTậpTinToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem lưuNộiDungVănBảnToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem địnhDạngToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btn_TaoFileMoi;
        private ToolStripButton btn_luuFile;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btn_indam;
        private ToolStripButton btn_innghien;
        private ToolStripButton btn_gacchchan;
        private ToolStripComboBox cmbFont;
        private ToolStripComboBox cmbsize;
    }
}
