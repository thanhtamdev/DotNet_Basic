
namespace Bai10
{
    partial class frmBai10
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoI = new System.Windows.Forms.RadioButton();
            this.rdoII = new System.Windows.Forms.RadioButton();
            this.rdoIII = new System.Windows.Forms.RadioButton();
            this.rdoIV = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.chklstSubject = new System.Windows.Forms.CheckedListBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlClass = new System.Windows.Forms.Panel();
            this.pnlClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(183, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÍ MÔN HỌC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(261, 112);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(326, 35);
            this.txtID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ và tên:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(261, 170);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(326, 35);
            this.txtFullName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Niên khóa:";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(261, 229);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(182, 35);
            this.cboYear.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lớp:";
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(261, 288);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(182, 35);
            this.cboClass.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Học kì:";
            // 
            // rdoI
            // 
            this.rdoI.AutoSize = true;
            this.rdoI.Checked = true;
            this.rdoI.Location = new System.Drawing.Point(3, 4);
            this.rdoI.Name = "rdoI";
            this.rdoI.Size = new System.Drawing.Size(45, 31);
            this.rdoI.TabIndex = 10;
            this.rdoI.TabStop = true;
            this.rdoI.Text = "I";
            this.rdoI.UseVisualStyleBackColor = true;
            this.rdoI.CheckedChanged += new System.EventHandler(this.rdoIV_CheckedChanged);
            // 
            // rdoII
            // 
            this.rdoII.AutoSize = true;
            this.rdoII.Location = new System.Drawing.Point(84, 4);
            this.rdoII.Name = "rdoII";
            this.rdoII.Size = new System.Drawing.Size(53, 31);
            this.rdoII.TabIndex = 11;
            this.rdoII.Text = "II";
            this.rdoII.UseVisualStyleBackColor = true;
            this.rdoII.CheckedChanged += new System.EventHandler(this.rdoIV_CheckedChanged);
            // 
            // rdoIII
            // 
            this.rdoIII.AutoSize = true;
            this.rdoIII.Location = new System.Drawing.Point(169, 4);
            this.rdoIII.Name = "rdoIII";
            this.rdoIII.Size = new System.Drawing.Size(61, 31);
            this.rdoIII.TabIndex = 12;
            this.rdoIII.Text = "III";
            this.rdoIII.UseVisualStyleBackColor = true;
            this.rdoIII.CheckedChanged += new System.EventHandler(this.rdoIV_CheckedChanged);
            // 
            // rdoIV
            // 
            this.rdoIV.AutoSize = true;
            this.rdoIV.Location = new System.Drawing.Point(262, 4);
            this.rdoIV.Name = "rdoIV";
            this.rdoIV.Size = new System.Drawing.Size(61, 31);
            this.rdoIV.TabIndex = 13;
            this.rdoIV.Text = "IV";
            this.rdoIV.UseVisualStyleBackColor = true;
            this.rdoIV.CheckedChanged += new System.EventHandler(this.rdoIV_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 27);
            this.label7.TabIndex = 14;
            this.label7.Text = "Môn học:";
            // 
            // chklstSubject
            // 
            this.chklstSubject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chklstSubject.CheckOnClick = true;
            this.chklstSubject.FormattingEnabled = true;
            this.chklstSubject.Items.AddRange(new object[] {
            "Lập trình Java basic",
            "Lập trình hướng đối tượng",
            "Nhập môn lập trình",
            "Kĩ thuật lập trình",
            "Lập trình web",
            "Hệ quản trị cơ sở dữ liệu",
            "Cấu trúc dữ liệu và giải thuật",
            "Lập trình Android basic",
            "Xác suất thống kê",
            "Hệ điều hành",
            "An toàn thông tin"});
            this.chklstSubject.Location = new System.Drawing.Point(261, 399);
            this.chklstSubject.Name = "chklstSubject";
            this.chklstSubject.ScrollAlwaysVisible = true;
            this.chklstSubject.Size = new System.Drawing.Size(326, 132);
            this.chklstSubject.TabIndex = 15;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(112, 563);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(112, 40);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Đăng kí";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(293, 563);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 40);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(475, 563);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 40);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pnlClass
            // 
            this.pnlClass.Controls.Add(this.rdoIII);
            this.pnlClass.Controls.Add(this.rdoI);
            this.pnlClass.Controls.Add(this.rdoII);
            this.pnlClass.Controls.Add(this.rdoIV);
            this.pnlClass.Location = new System.Drawing.Point(261, 341);
            this.pnlClass.Name = "pnlClass";
            this.pnlClass.Size = new System.Drawing.Size(326, 40);
            this.pnlClass.TabIndex = 19;
            // 
            // frmBai10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 639);
            this.Controls.Add(this.pnlClass);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.chklstSubject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBai10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBai10";
            this.Load += new System.EventHandler(this.frmBai10_Load);
            this.pnlClass.ResumeLayout(false);
            this.pnlClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdoI;
        private System.Windows.Forms.RadioButton rdoII;
        private System.Windows.Forms.RadioButton rdoIII;
        private System.Windows.Forms.RadioButton rdoIV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox chklstSubject;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlClass;
    }
}