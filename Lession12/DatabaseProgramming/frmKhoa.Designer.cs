
namespace DatabaseProgramming
{
    partial class frmKhoa
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
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lvwKhoa = new System.Windows.Forms.ListView();
            this.MaKhoa = new System.Windows.Forms.ColumnHeader();
            this.TenKhoa = new System.Windows.Forms.ColumnHeader();
            this.DienThoai = new System.Windows.Forms.ColumnHeader();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(441, 31);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(367, 35);
            this.txtMaKhoa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã khoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khoa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Điện thoại:";
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(441, 112);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(367, 35);
            this.txtTenKhoa.TabIndex = 4;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(441, 191);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(367, 35);
            this.txtDienThoai.TabIndex = 5;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(364, 308);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 44);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lvwKhoa
            // 
            this.lvwKhoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaKhoa,
            this.TenKhoa,
            this.DienThoai});
            this.lvwKhoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvwKhoa.FullRowSelect = true;
            this.lvwKhoa.GridLines = true;
            this.lvwKhoa.HideSelection = false;
            this.lvwKhoa.Location = new System.Drawing.Point(0, 393);
            this.lvwKhoa.Name = "lvwKhoa";
            this.lvwKhoa.Size = new System.Drawing.Size(990, 339);
            this.lvwKhoa.TabIndex = 7;
            this.lvwKhoa.UseCompatibleStateImageBehavior = false;
            this.lvwKhoa.View = System.Windows.Forms.View.Details;
            this.lvwKhoa.SelectedIndexChanged += new System.EventHandler(this.lvwKhoa_SelectedIndexChanged);
            // 
            // MaKhoa
            // 
            this.MaKhoa.Text = "Mã khoa";
            this.MaKhoa.Width = 150;
            // 
            // TenKhoa
            // 
            this.TenKhoa.Text = "Tên khoa";
            this.TenKhoa.Width = 350;
            // 
            // DienThoai
            // 
            this.DienThoai.Text = "Điện thoại";
            this.DienThoai.Width = 150;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(506, 308);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(115, 44);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // frmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 732);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.lvwKhoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtTenKhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaKhoa);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKhoa";
            this.Load += new System.EventHandler(this.frmKhoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ListView lvwKhoa;
        private System.Windows.Forms.ColumnHeader MaKhoa;
        private System.Windows.Forms.ColumnHeader TenKhoa;
        private System.Windows.Forms.ColumnHeader DienThoai;
        private System.Windows.Forms.Button btnCapNhat;
    }
}