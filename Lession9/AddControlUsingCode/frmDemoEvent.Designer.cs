
namespace AddControlUsingCode
{
    partial class frmDemoEvent
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtKienHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSachMoiKien = new System.Windows.Forms.TextBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongSach = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEMO EVENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số kiện hàng:";
            // 
            // txtKienHang
            // 
            this.txtKienHang.Location = new System.Drawing.Point(334, 111);
            this.txtKienHang.Name = "txtKienHang";
            this.txtKienHang.Size = new System.Drawing.Size(274, 35);
            this.txtKienHang.TabIndex = 2;
            this.txtKienHang.TextChanged += new System.EventHandler(this.XoaTextBoxTong);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số sách trong mỗi kiện:";
            // 
            // txtSachMoiKien
            // 
            this.txtSachMoiKien.Location = new System.Drawing.Point(334, 199);
            this.txtSachMoiKien.Name = "txtSachMoiKien";
            this.txtSachMoiKien.Size = new System.Drawing.Size(274, 35);
            this.txtSachMoiKien.TabIndex = 4;
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(334, 289);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(119, 52);
            this.btnTinhTong.TabIndex = 5;
            this.btnTinhTong.Text = "Tính tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng số sách:";
            // 
            // txtTongSach
            // 
            this.txtTongSach.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtTongSach.Location = new System.Drawing.Point(334, 384);
            this.txtTongSach.Name = "txtTongSach";
            this.txtTongSach.Size = new System.Drawing.Size(288, 35);
            this.txtTongSach.TabIndex = 7;
            // 
            // frmDemoEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 473);
            this.Controls.Add(this.txtTongSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.txtSachMoiKien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKienHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDemoEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDemoEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKienHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSachMoiKien;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongSach;
    }
}