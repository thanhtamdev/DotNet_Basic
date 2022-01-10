
namespace MenuAndToolBar
{
    partial class frmMenuStrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuStrip));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCapTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuDanhMuc,
            this.mnuThongKe,
            this.mnuTimKiem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCapTaiKhoan,
            this.mnuDoiMK,
            this.mnuDangXuat});
            this.mnuHeThong.Image = ((System.Drawing.Image)(resources.GetObject("mnuHeThong.Image")));
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(127, 29);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // mnuCapTaiKhoan
            // 
            this.mnuCapTaiKhoan.Name = "mnuCapTaiKhoan";
            this.mnuCapTaiKhoan.Size = new System.Drawing.Size(223, 34);
            this.mnuCapTaiKhoan.Text = "Cấp tài khoản";
            // 
            // mnuDoiMK
            // 
            this.mnuDoiMK.Name = "mnuDoiMK";
            this.mnuDoiMK.Size = new System.Drawing.Size(223, 34);
            this.mnuDoiMK.Text = "Đổi mật khẩu";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(223, 34);
            this.mnuDangXuat.Text = "Đăng xuất";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKhoa,
            this.mnuLop,
            this.mnuSinhVien});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(109, 29);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuKhoa
            // 
            this.mnuKhoa.Name = "mnuKhoa";
            this.mnuKhoa.Size = new System.Drawing.Size(270, 34);
            this.mnuKhoa.Text = "Khoa";
            // 
            // mnuLop
            // 
            this.mnuLop.Name = "mnuLop";
            this.mnuLop.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.mnuLop.ShowShortcutKeys = false;
            this.mnuLop.Size = new System.Drawing.Size(270, 34);
            this.mnuLop.Text = "Lớp";
            // 
            // mnuSinhVien
            // 
            this.mnuSinhVien.Name = "mnuSinhVien";
            this.mnuSinhVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuSinhVien.Size = new System.Drawing.Size(270, 34);
            this.mnuSinhVien.Text = "Sinh viên";
            this.mnuSinhVien.Click += new System.EventHandler(this.mnuSinhVien_Click);
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(102, 29);
            this.mnuThongKe.Text = "Thống kê";
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(100, 29);
            this.mnuTimKiem.Text = "Tìm kiếm";
            // 
            // frmMenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 607);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMenuStrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuStrip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuCapTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMK;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuKhoa;
        private System.Windows.Forms.ToolStripMenuItem mnuLop;
        private System.Windows.Forms.ToolStripMenuItem mnuSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
    }
}