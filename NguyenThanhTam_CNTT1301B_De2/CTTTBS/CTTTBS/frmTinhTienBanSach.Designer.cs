
namespace CTTTBS
{
    partial class frmTinhTienBanSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkKHSV = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSLS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKT = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnTT = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongKHSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHƯƠNG TRÌNH TÍNH TIỀN BÁN SÁCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkKHSV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSLS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(97, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 278);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // chkKHSV
            // 
            this.chkKHSV.AutoSize = true;
            this.chkKHSV.Location = new System.Drawing.Point(210, 157);
            this.chkKHSV.Name = "chkKHSV";
            this.chkKHSV.Size = new System.Drawing.Size(22, 21);
            this.chkKHSV.TabIndex = 3;
            this.chkKHSV.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Khách hàng là SV:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(210, 209);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(300, 33);
            this.txtThanhTien.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thành tiền:";
            // 
            // txtSLS
            // 
            this.txtSLS.Location = new System.Drawing.Point(210, 104);
            this.txtSLS.Name = "txtSLS";
            this.txtSLS.Size = new System.Drawing.Size(300, 33);
            this.txtSLS.TabIndex = 2;
            this.txtSLS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenKH_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng sách:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(210, 56);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(301, 33);
            this.txtTenKH.TabIndex = 1;
            this.txtTenKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenKH_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKT);
            this.groupBox2.Controls.Add(this.btnThongKe);
            this.groupBox2.Controls.Add(this.btnTiep);
            this.groupBox2.Controls.Add(this.btnTT);
            this.groupBox2.Location = new System.Drawing.Point(97, 433);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 105);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnKT
            // 
            this.btnKT.Location = new System.Drawing.Point(429, 32);
            this.btnKT.Name = "btnKT";
            this.btnKT.Size = new System.Drawing.Size(118, 55);
            this.btnKT.TabIndex = 7;
            this.btnKT.Text = "Kết thúc";
            this.btnKT.UseVisualStyleBackColor = true;
            this.btnKT.Click += new System.EventHandler(this.btnKT_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(293, 32);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(118, 55);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(157, 32);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(118, 55);
            this.btnTiep.TabIndex = 5;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnTT
            // 
            this.btnTT.Location = new System.Drawing.Point(19, 32);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(118, 55);
            this.btnTT.TabIndex = 4;
            this.btnTT.Text = "Tính TT";
            this.btnTT.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTongDoanhThu);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtTongKHSV);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTongKH);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(97, 558);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(577, 203);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống kê";
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Enabled = false;
            this.txtTongDoanhThu.Location = new System.Drawing.Point(239, 142);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(272, 33);
            this.txtTongDoanhThu.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tổng doanh thu:";
            // 
            // txtTongKHSV
            // 
            this.txtTongKHSV.Enabled = false;
            this.txtTongKHSV.Location = new System.Drawing.Point(239, 94);
            this.txtTongKHSV.Name = "txtTongKHSV";
            this.txtTongKHSV.Size = new System.Drawing.Size(272, 33);
            this.txtTongKHSV.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tổng số KH là SV:";
            // 
            // txtTongKH
            // 
            this.txtTongKH.Enabled = false;
            this.txtTongKH.Location = new System.Drawing.Point(239, 46);
            this.txtTongKH.Name = "txtTongKH";
            this.txtTongKH.Size = new System.Drawing.Size(272, 33);
            this.txtTongKH.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tổng số KH:";
            // 
            // frmTinhTienBanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 801);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmTinhTienBanSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTinhTienBanSach";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSLS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkKHSV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Button btnKT;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongKHSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongKH;
        private System.Windows.Forms.Label label7;
    }
}