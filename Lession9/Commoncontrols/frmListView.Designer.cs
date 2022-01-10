
namespace Commoncontrols
{
    partial class frmListView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboLopHoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwSinhVien = new System.Windows.Forms.ListView();
            this.MaSV = new System.Windows.Forms.ColumnHeader();
            this.HoTen = new System.Windows.Forms.ColumnHeader();
            this.DiaChi = new System.Windows.Forms.ColumnHeader();
            this.NgaySinh = new System.Windows.Forms.ColumnHeader();
            this.Lop = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuXem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cboLopHoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(72, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(588, 306);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(138, 46);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(588, 228);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 48);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(588, 156);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(138, 46);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(588, 76);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(138, 53);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHoc.FormattingEnabled = true;
            this.cboLopHoc.Location = new System.Drawing.Point(203, 322);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(172, 35);
            this.cboLopHoc.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lớp:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(203, 257);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(172, 35);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày sinh:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(203, 194);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(340, 35);
            this.txtDiaChi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(203, 132);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(340, 35);
            this.txtHoTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(203, 73);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(340, 35);
            this.txtMaSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // lvwSinhVien
            // 
            this.lvwSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaSV,
            this.HoTen,
            this.DiaChi,
            this.NgaySinh,
            this.Lop});
            this.lvwSinhVien.ContextMenuStrip = this.contextMenuStrip1;
            this.lvwSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvwSinhVien.FullRowSelect = true;
            this.lvwSinhVien.GridLines = true;
            this.lvwSinhVien.HideSelection = false;
            this.lvwSinhVien.Location = new System.Drawing.Point(0, 462);
            this.lvwSinhVien.Name = "lvwSinhVien";
            this.lvwSinhVien.Size = new System.Drawing.Size(920, 233);
            this.lvwSinhVien.TabIndex = 1;
            this.lvwSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvwSinhVien.View = System.Windows.Forms.View.Details;
            // 
            // MaSV
            // 
            this.MaSV.Text = "Mã sinh viên";
            this.MaSV.Width = 150;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ tên";
            this.HoTen.Width = 250;
            // 
            // DiaChi
            // 
            this.DiaChi.Text = "Địa chỉ";
            this.DiaChi.Width = 250;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Text = "Ngày sinh";
            this.NgaySinh.Width = 150;
            // 
            // Lop
            // 
            this.Lop.Text = "Lớp";
            this.Lop.Width = 120;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXem,
            this.mnuSua,
            this.mnuXoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 100);
            // 
            // mnuXem
            // 
            this.mnuXem.Image = ((System.Drawing.Image)(resources.GetObject("mnuXem.Image")));
            this.mnuXem.Name = "mnuXem";
            this.mnuXem.Size = new System.Drawing.Size(128, 32);
            this.mnuXem.Text = "Xem";
            // 
            // mnuSua
            // 
            this.mnuSua.Name = "mnuSua";
            this.mnuSua.Size = new System.Drawing.Size(128, 32);
            this.mnuSua.Text = "Sửa";
            // 
            // mnuXoa
            // 
            this.mnuXoa.Name = "mnuXoa";
            this.mnuXoa.Size = new System.Drawing.Size(128, 32);
            this.mnuXoa.Text = "Xóa";
            // 
            // frmListView
            // 
            this.AcceptButton = this.btnCapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 695);
            this.Controls.Add(this.lvwSinhVien);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListView";
            this.Load += new System.EventHandler(this.frmListView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboLopHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwSinhVien;
        private System.Windows.Forms.ColumnHeader MaSV;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader DiaChi;
        private System.Windows.Forms.ColumnHeader NgaySinh;
        private System.Windows.Forms.ColumnHeader Lop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuXem;
        private System.Windows.Forms.ToolStripMenuItem mnuSua;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa;
    }
}