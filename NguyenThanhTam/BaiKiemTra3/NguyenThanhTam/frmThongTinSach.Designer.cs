
namespace NguyenThanhTam
{
    partial class frmThongTinSach
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
            this.cboLoaiSach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lvwTTSach = new System.Windows.Forms.ListView();
            this.ProductCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OnHandQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.bntBoQua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboLoaiSach
            // 
            this.cboLoaiSach.FormattingEnabled = true;
            this.cboLoaiSach.Location = new System.Drawing.Point(181, 40);
            this.cboLoaiSach.Name = "cboLoaiSach";
            this.cboLoaiSach.Size = new System.Drawing.Size(252, 31);
            this.cboLoaiSach.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sách:";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(181, 86);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(252, 31);
            this.txtMaSach.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiêu đề:";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(181, 132);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(252, 31);
            this.txtTieuDe.TabIndex = 5;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(635, 40);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(195, 31);
            this.txtGia.TabIndex = 6;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(635, 100);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(195, 31);
            this.txtSoLuong.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số lượng:";
            // 
            // lvwTTSach
            // 
            this.lvwTTSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductCode,
            this.Description,
            this.UnitPrice,
            this.OnHandQuantity});
            this.lvwTTSach.FullRowSelect = true;
            this.lvwTTSach.GridLines = true;
            this.lvwTTSach.HideSelection = false;
            this.lvwTTSach.Location = new System.Drawing.Point(48, 230);
            this.lvwTTSach.Name = "lvwTTSach";
            this.lvwTTSach.Size = new System.Drawing.Size(782, 226);
            this.lvwTTSach.TabIndex = 10;
            this.lvwTTSach.UseCompatibleStateImageBehavior = false;
            this.lvwTTSach.View = System.Windows.Forms.View.Details;
            // 
            // ProductCode
            // 
            this.ProductCode.Text = "Mã sách";
            this.ProductCode.Width = 200;
            // 
            // Description
            // 
            this.Description.Text = "Tiêu đề";
            this.Description.Width = 300;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "Giá";
            this.UnitPrice.Width = 150;
            // 
            // OnHandQuantity
            // 
            this.OnHandQuantity.Text = "Số lượng";
            this.OnHandQuantity.Width = 150;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(66, 503);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(114, 54);
            this.btnThemMoi.TabIndex = 11;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(217, 503);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(114, 54);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(376, 503);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 54);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(524, 503);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 54);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // bntBoQua
            // 
            this.bntBoQua.Enabled = false;
            this.bntBoQua.Location = new System.Drawing.Point(681, 503);
            this.bntBoQua.Name = "bntBoQua";
            this.bntBoQua.Size = new System.Drawing.Size(114, 54);
            this.bntBoQua.TabIndex = 15;
            this.bntBoQua.Text = "Bỏ qua";
            this.bntBoQua.UseVisualStyleBackColor = true;
            // 
            // frmThongTinSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 569);
            this.Controls.Add(this.bntBoQua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.lvwTTSach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLoaiSach);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmThongTinSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sách";
            this.Load += new System.EventHandler(this.frmThongTinSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLoaiSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvwTTSach;
        private System.Windows.Forms.ColumnHeader ProductCode;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.ColumnHeader OnHandQuantity;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button bntBoQua;
    }
}