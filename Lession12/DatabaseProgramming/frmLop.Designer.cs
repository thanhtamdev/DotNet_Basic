
namespace DatabaseProgramming
{
    partial class frmLop
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
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(319, 44);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(281, 35);
            this.txtMaLop.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên lớp:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(319, 114);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(281, 35);
            this.txtTenLop.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khoa:";
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(319, 187);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(182, 35);
            this.cboKhoa.TabIndex = 5;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 486);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLop";
            this.Load += new System.EventHandler(this.frmLop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboKhoa;
    }
}