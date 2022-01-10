
namespace VTDT.GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiCV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCapCQBH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCQBH = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiCôngVănToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHienThi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuLoaiCV,
            this.mnuHienThi,
            this.mnuTimKiem,
            this.mnuThongKe,
            this.mnuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.Image = ((System.Drawing.Image)(resources.GetObject("mnuHeThong.Image")));
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(127, 29);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // mnuLoaiCV
            // 
            this.mnuLoaiCV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCapCQBH,
            this.mnuCQBH,
            this.loạiCôngVănToolStripMenuItem,
            this.mnuChucVu,
            this.mnuPhongBan});
            this.mnuLoaiCV.Image = ((System.Drawing.Image)(resources.GetObject("mnuLoaiCV.Image")));
            this.mnuLoaiCV.Name = "mnuLoaiCV";
            this.mnuLoaiCV.Size = new System.Drawing.Size(196, 29);
            this.mnuLoaiCV.Text = "Danh mục hiển thị";
            // 
            // mnuCapCQBH
            // 
            this.mnuCapCQBH.Image = ((System.Drawing.Image)(resources.GetObject("mnuCapCQBH.Image")));
            this.mnuCapCQBH.Name = "mnuCapCQBH";
            this.mnuCapCQBH.Size = new System.Drawing.Size(260, 34);
            this.mnuCapCQBH.Text = "Cấp CQBH";
            this.mnuCapCQBH.Click += new System.EventHandler(this.mnuCapCQBH_Click);
            // 
            // mnuCQBH
            // 
            this.mnuCQBH.Image = ((System.Drawing.Image)(resources.GetObject("mnuCQBH.Image")));
            this.mnuCQBH.Name = "mnuCQBH";
            this.mnuCQBH.Size = new System.Drawing.Size(260, 34);
            this.mnuCQBH.Text = "Cơ quan ban hành";
            // 
            // loạiCôngVănToolStripMenuItem
            // 
            this.loạiCôngVănToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loạiCôngVănToolStripMenuItem.Image")));
            this.loạiCôngVănToolStripMenuItem.Name = "loạiCôngVănToolStripMenuItem";
            this.loạiCôngVănToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.loạiCôngVănToolStripMenuItem.Text = "Loại công văn";
            // 
            // mnuChucVu
            // 
            this.mnuChucVu.Image = ((System.Drawing.Image)(resources.GetObject("mnuChucVu.Image")));
            this.mnuChucVu.Name = "mnuChucVu";
            this.mnuChucVu.Size = new System.Drawing.Size(260, 34);
            this.mnuChucVu.Text = "Chức vụ";
            // 
            // mnuPhongBan
            // 
            this.mnuPhongBan.Image = ((System.Drawing.Image)(resources.GetObject("mnuPhongBan.Image")));
            this.mnuPhongBan.Name = "mnuPhongBan";
            this.mnuPhongBan.Size = new System.Drawing.Size(260, 34);
            this.mnuPhongBan.Text = "Phòng ban";
            // 
            // mnuHienThi
            // 
            this.mnuHienThi.Image = ((System.Drawing.Image)(resources.GetObject("mnuHienThi.Image")));
            this.mnuHienThi.Name = "mnuHienThi";
            this.mnuHienThi.Size = new System.Drawing.Size(113, 29);
            this.mnuHienThi.Text = "Hiển thị";
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("mnuTimKiem.Image")));
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(124, 29);
            this.mnuTimKiem.Text = "Tìm kiếm";
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.Image = ((System.Drawing.Image)(resources.GetObject("mnuThongKe.Image")));
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(126, 29);
            this.mnuThongKe.Text = "Thống kê";
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.Image = ((System.Drawing.Image)(resources.GetObject("mnuTroGiup.Image")));
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(117, 29);
            this.mnuTroGiup.Text = "Trợ giúp";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1292, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(233, 29);
            this.toolStripButton1.Text = "Thêm mới công văn đến";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 29);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 672);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VĂN THƯ ĐIỆN TỬ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiCV;
        private System.Windows.Forms.ToolStripMenuItem mnuHienThi;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuCapCQBH;
        private System.Windows.Forms.ToolStripMenuItem mnuCQBH;
        private System.Windows.Forms.ToolStripMenuItem loạiCôngVănToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuChucVu;
        private System.Windows.Forms.ToolStripMenuItem mnuPhongBan;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}