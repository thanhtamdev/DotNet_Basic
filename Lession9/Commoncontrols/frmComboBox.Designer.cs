
namespace Commoncontrols
{
    partial class frmComboBox
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
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNamSinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayNhapHoc = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(357, 103);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(351, 35);
            this.txtMaSV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 35);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm sinh:";
            // 
            // cboNamSinh
            // 
            this.cboNamSinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamSinh.FormattingEnabled = true;
            this.cboNamSinh.Location = new System.Drawing.Point(357, 268);
            this.cboNamSinh.Name = "cboNamSinh";
            this.cboNamSinh.Size = new System.Drawing.Size(182, 35);
            this.cboNamSinh.TabIndex = 5;
            this.cboNamSinh.DropDown += new System.EventHandler(this.frmComboBox_Load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(720, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lớp:";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(858, 268);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(182, 35);
            this.cboLop.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày nhập học:";
            // 
            // dtpNgayNhapHoc
            // 
            this.dtpNgayNhapHoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhapHoc.Location = new System.Drawing.Point(357, 344);
            this.dtpNgayNhapHoc.Name = "dtpNgayNhapHoc";
            this.dtpNgayNhapHoc.Size = new System.Drawing.Size(300, 35);
            this.dtpNgayNhapHoc.TabIndex = 9;
            // 
            // frmComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 757);
            this.Controls.Add(this.dtpNgayNhapHoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboNamSinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNamSinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayNhapHoc;
    }
}