
namespace Bai2
{
    partial class frmBai2
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
            this.txtNhapNam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(142, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "XEM NĂM THEO CAN CHI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập năm cần xem:";
            // 
            // txtNhapNam
            // 
            this.txtNhapNam.Location = new System.Drawing.Point(345, 132);
            this.txtNhapNam.Name = "txtNhapNam";
            this.txtNhapNam.Size = new System.Drawing.Size(215, 35);
            this.txtNhapNam.TabIndex = 1;
            this.txtNhapNam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhapNam_KeyDown);
            this.txtNhapNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapNam_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm tương ứng:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtKetQua.Location = new System.Drawing.Point(345, 210);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(215, 35);
            this.txtKetQua.TabIndex = 4;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(170, 295);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(102, 45);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(315, 296);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 45);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(458, 296);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 44);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 432);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNhapNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}