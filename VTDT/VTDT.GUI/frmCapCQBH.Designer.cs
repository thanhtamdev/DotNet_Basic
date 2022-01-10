
namespace VTDT.GUI
{
    partial class frmCapCQBH
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
            this.txtMaCapCQBH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenCapCQBH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã cấp CQBH:";
            // 
            // txtMaCapCQBH
            // 
            this.txtMaCapCQBH.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaCapCQBH.Location = new System.Drawing.Point(273, 59);
            this.txtMaCapCQBH.Name = "txtMaCapCQBH";
            this.txtMaCapCQBH.Size = new System.Drawing.Size(393, 35);
            this.txtMaCapCQBH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên cấp CQBH:";
            // 
            // txtTenCapCQBH
            // 
            this.txtTenCapCQBH.BackColor = System.Drawing.SystemColors.Info;
            this.txtTenCapCQBH.Location = new System.Drawing.Point(273, 151);
            this.txtTenCapCQBH.Name = "txtTenCapCQBH";
            this.txtTenCapCQBH.Size = new System.Drawing.Size(392, 35);
            this.txtTenCapCQBH.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(273, 249);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(393, 170);
            this.txtGhiChu.TabIndex = 5;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(150, 461);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 50);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(305, 461);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(107, 50);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // frmCapCQBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 574);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenCapCQBH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaCapCQBH);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCapCQBH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM MỚI CẤP CQBH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCapCQBH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenCapCQBH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}