
namespace Bai3
{
    partial class frmBai3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeSoA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeSoB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.errorProviderA = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderB = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(78, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC NHẤT ax + b = 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(250, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hệ số a:";
            // 
            // txtHeSoA
            // 
            this.txtHeSoA.Location = new System.Drawing.Point(355, 122);
            this.txtHeSoA.Name = "txtHeSoA";
            this.txtHeSoA.Size = new System.Drawing.Size(266, 35);
            this.txtHeSoA.TabIndex = 1;
            this.txtHeSoA.Validating += new System.ComponentModel.CancelEventHandler(this.txtHeSoA_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hệ số b:";
            // 
            // txtHeSoB
            // 
            this.txtHeSoB.Location = new System.Drawing.Point(355, 193);
            this.txtHeSoB.Name = "txtHeSoB";
            this.txtHeSoB.Size = new System.Drawing.Size(266, 35);
            this.txtHeSoB.TabIndex = 2;
            this.txtHeSoB.Validating += new System.ComponentModel.CancelEventHandler(this.txtHeSoB_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nghiệm của phương trình:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtKetQua.Location = new System.Drawing.Point(355, 261);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(266, 35);
            this.txtKetQua.TabIndex = 6;
            // 
            // btnGiai
            // 
            this.btnGiai.Location = new System.Drawing.Point(260, 347);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(81, 43);
            this.btnGiai.TabIndex = 3;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(540, 347);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 43);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(403, 347);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 43);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // errorProviderA
            // 
            this.errorProviderA.ContainerControl = this;
            // 
            // errorProviderB
            // 
            this.errorProviderB.ContainerControl = this;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 486);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHeSoB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHeSoA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBai3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBai3";
            this.Load += new System.EventHandler(this.frmBai3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeSoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeSoB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ErrorProvider errorProviderA;
        private System.Windows.Forms.ErrorProvider errorProviderB;
    }
}