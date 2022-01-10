
namespace BT12
{
    partial class frmNhanVien
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvwNhanVien = new System.Windows.Forms.ListView();
            this.MaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTenNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DienThoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BangCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboBangCap = new System.Windows.Forms.ComboBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvwNhanVien);
            this.groupBox3.Location = new System.Drawing.Point(37, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1037, 202);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chung";
            // 
            // lvwNhanVien
            // 
            this.lvwNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNV,
            this.HoTenNhanVien,
            this.NgaySinh,
            this.DiaChi,
            this.DienThoai,
            this.BangCap});
            this.lvwNhanVien.FullRowSelect = true;
            this.lvwNhanVien.GridLines = true;
            this.lvwNhanVien.HideSelection = false;
            this.lvwNhanVien.Location = new System.Drawing.Point(24, 30);
            this.lvwNhanVien.Name = "lvwNhanVien";
            this.lvwNhanVien.Size = new System.Drawing.Size(991, 171);
            this.lvwNhanVien.TabIndex = 0;
            this.lvwNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvwNhanVien.View = System.Windows.Forms.View.Details;
            this.lvwNhanVien.SelectedIndexChanged += new System.EventHandler(this.lvwNhanVien_SelectedIndexChanged);
            // 
            // MaNV
            // 
            this.MaNV.Text = "Mã nhân viên";
            this.MaNV.Width = 150;
            // 
            // HoTenNhanVien
            // 
            this.HoTenNhanVien.Text = "Họ tên";
            this.HoTenNhanVien.Width = 250;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Text = "Ngày sinh";
            this.NgaySinh.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.Text = "Địa chỉ";
            this.DiaChi.Width = 250;
            // 
            // DienThoai
            // 
            this.DienThoai.Text = "Điện thoại";
            this.DienThoai.Width = 120;
            // 
            // BangCap
            // 
            this.BangCap.Text = "Bằng cấp";
            this.BangCap.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(467, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 84);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(499, 29);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 42);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(404, 29);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 42);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(309, 29);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(89, 42);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(214, 29);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 42);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(116, 29);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 42);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(21, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 42);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboBangCap);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(37, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1037, 177);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // cboBangCap
            // 
            this.cboBangCap.FormattingEnabled = true;
            this.cboBangCap.Location = new System.Drawing.Point(737, 84);
            this.cboBangCap.Name = "cboBangCap";
            this.cboBangCap.Size = new System.Drawing.Size(278, 31);
            this.cboBangCap.TabIndex = 9;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(737, 34);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(278, 31);
            this.txtDienThoai.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bằng cấp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Điện thoại:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(169, 129);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(304, 31);
            this.txtDiaChi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(169, 81);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(304, 31);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(169, 34);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(304, 31);
            this.txtHoTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(398, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 531);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvwNhanVien;
        private System.Windows.Forms.ColumnHeader MaNV;
        private System.Windows.Forms.ColumnHeader HoTenNhanVien;
        private System.Windows.Forms.ColumnHeader NgaySinh;
        private System.Windows.Forms.ColumnHeader DiaChi;
        private System.Windows.Forms.ColumnHeader DienThoai;
        private System.Windows.Forms.ColumnHeader BangCap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboBangCap;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}