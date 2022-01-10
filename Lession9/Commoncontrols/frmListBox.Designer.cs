
namespace Commoncontrols
{
    partial class frmListBox
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
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstLopA = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstLopB = new System.Windows.Forms.ListBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnASangB = new System.Windows.Forms.Button();
            this.btnASangBAll = new System.Windows.Forms.Button();
            this.btnBSangA = new System.Windows.Forms.Button();
            this.btnBSangAAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(442, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(383, 91);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(294, 35);
            this.txtHoten.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(738, 92);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(112, 34);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstLopA);
            this.groupBox1.Location = new System.Drawing.Point(177, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 451);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // lstLopA
            // 
            this.lstLopA.FormattingEnabled = true;
            this.lstLopA.ItemHeight = 27;
            this.lstLopA.Location = new System.Drawing.Point(27, 45);
            this.lstLopA.Name = "lstLopA";
            this.lstLopA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstLopA.Size = new System.Drawing.Size(266, 382);
            this.lstLopA.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstLopB);
            this.groupBox2.Location = new System.Drawing.Point(682, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 451);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // lstLopB
            // 
            this.lstLopB.FormattingEnabled = true;
            this.lstLopB.ItemHeight = 27;
            this.lstLopB.Location = new System.Drawing.Point(22, 45);
            this.lstLopB.Name = "lstLopB";
            this.lstLopB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstLopB.Size = new System.Drawing.Size(277, 382);
            this.lstLopB.TabIndex = 8;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(286, 700);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(738, 700);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(112, 34);
            this.btnKetThuc.TabIndex = 10;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            // 
            // btnASangB
            // 
            this.btnASangB.Location = new System.Drawing.Point(534, 240);
            this.btnASangB.Name = "btnASangB";
            this.btnASangB.Size = new System.Drawing.Size(112, 34);
            this.btnASangB.TabIndex = 4;
            this.btnASangB.Text = ">";
            this.btnASangB.UseVisualStyleBackColor = true;
            this.btnASangB.Click += new System.EventHandler(this.btnASangB_Click);
            // 
            // btnASangBAll
            // 
            this.btnASangBAll.Location = new System.Drawing.Point(534, 317);
            this.btnASangBAll.Name = "btnASangBAll";
            this.btnASangBAll.Size = new System.Drawing.Size(112, 34);
            this.btnASangBAll.TabIndex = 5;
            this.btnASangBAll.Text = ">>";
            this.btnASangBAll.UseVisualStyleBackColor = true;
            this.btnASangBAll.Click += new System.EventHandler(this.btnASangBAll_Click);
            // 
            // btnBSangA
            // 
            this.btnBSangA.Location = new System.Drawing.Point(534, 385);
            this.btnBSangA.Name = "btnBSangA";
            this.btnBSangA.Size = new System.Drawing.Size(112, 34);
            this.btnBSangA.TabIndex = 6;
            this.btnBSangA.Text = "<";
            this.btnBSangA.UseVisualStyleBackColor = true;
            // 
            // btnBSangAAll
            // 
            this.btnBSangAAll.Location = new System.Drawing.Point(534, 449);
            this.btnBSangAAll.Name = "btnBSangAAll";
            this.btnBSangAAll.Size = new System.Drawing.Size(112, 34);
            this.btnBSangAAll.TabIndex = 7;
            this.btnBSangAAll.Text = "<<";
            this.btnBSangAAll.UseVisualStyleBackColor = true;
            // 
            // frmListBox
            // 
            this.AcceptButton = this.btnCapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 770);
            this.Controls.Add(this.btnBSangAAll);
            this.Controls.Add(this.btnBSangA);
            this.Controls.Add(this.btnASangBAll);
            this.Controls.Add(this.btnASangB);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH SINH VIÊN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstLopB;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnASangB;
        private System.Windows.Forms.Button btnASangBAll;
        private System.Windows.Forms.Button btnBSangA;
        private System.Windows.Forms.Button btnBSangAAll;
    }
}