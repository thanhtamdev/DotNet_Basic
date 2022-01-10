
namespace Bai7
{
    partial class frmBai7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSo = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstUoc = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTongUoc = new System.Windows.Forms.Button();
            this.btnSLUocChan = new System.Windows.Forms.Button();
            this.btnSLUocSNT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSo);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.txtNhapSo);
            this.groupBox1.Location = new System.Drawing.Point(46, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // cboSo
            // 
            this.cboSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSo.FormattingEnabled = true;
            this.cboSo.Location = new System.Drawing.Point(23, 116);
            this.cboSo.Name = "cboSo";
            this.cboSo.Size = new System.Drawing.Size(284, 35);
            this.cboSo.TabIndex = 3;
            this.cboSo.SelectedIndexChanged += new System.EventHandler(this.cboSo_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(195, 36);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(112, 48);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(23, 44);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(150, 35);
            this.txtNhapSo.TabIndex = 1;
            this.txtNhapSo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhapSo_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstUoc);
            this.groupBox2.Location = new System.Drawing.Point(450, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 188);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // lstUoc
            // 
            this.lstUoc.FormattingEnabled = true;
            this.lstUoc.ItemHeight = 27;
            this.lstUoc.Location = new System.Drawing.Point(24, 34);
            this.lstUoc.Name = "lstUoc";
            this.lstUoc.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstUoc.Size = new System.Drawing.Size(295, 139);
            this.lstUoc.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(277, 400);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 50);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTongUoc
            // 
            this.btnTongUoc.Location = new System.Drawing.Point(450, 242);
            this.btnTongUoc.Name = "btnTongUoc";
            this.btnTongUoc.Size = new System.Drawing.Size(339, 50);
            this.btnTongUoc.TabIndex = 5;
            this.btnTongUoc.Text = "Tổng các ước số";
            this.btnTongUoc.UseVisualStyleBackColor = true;
            this.btnTongUoc.Click += new System.EventHandler(this.btnTongUoc_Click);
            // 
            // btnSLUocChan
            // 
            this.btnSLUocChan.Location = new System.Drawing.Point(450, 322);
            this.btnSLUocChan.Name = "btnSLUocChan";
            this.btnSLUocChan.Size = new System.Drawing.Size(339, 50);
            this.btnSLUocChan.TabIndex = 6;
            this.btnSLUocChan.Text = "Số lượng các ước số chẵn";
            this.btnSLUocChan.UseVisualStyleBackColor = true;
            this.btnSLUocChan.Click += new System.EventHandler(this.btnSLUocChan_Click);
            // 
            // btnSLUocSNT
            // 
            this.btnSLUocSNT.Location = new System.Drawing.Point(450, 400);
            this.btnSLUocSNT.Name = "btnSLUocSNT";
            this.btnSLUocSNT.Size = new System.Drawing.Size(339, 50);
            this.btnSLUocSNT.TabIndex = 7;
            this.btnSLUocSNT.Text = "Số lượng các ước số nguyên tố";
            this.btnSLUocSNT.UseVisualStyleBackColor = true;
            this.btnSLUocSNT.Click += new System.EventHandler(this.btnSLUocSNT_Click);
            // 
            // frmBai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 481);
            this.Controls.Add(this.btnSLUocSNT);
            this.Controls.Add(this.btnSLUocChan);
            this.Controls.Add(this.btnTongUoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBai7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBai7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboSo;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstUoc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTongUoc;
        private System.Windows.Forms.Button btnSLUocChan;
        private System.Windows.Forms.Button btnSLUocSNT;
    }
}