
namespace Bai1
{
    partial class frmBai1
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
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(127, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỰC HIỆN CÁC PHÉP TÍNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số a:";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(251, 116);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(287, 35);
            this.txtSoA.TabIndex = 2;
            this.txtSoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoA_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập số b:";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(251, 193);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(287, 35);
            this.txtSoB.TabIndex = 4;
            this.txtSoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoB_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.SystemColors.Info;
            this.txtKetQua.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtKetQua.Location = new System.Drawing.Point(251, 266);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(287, 35);
            this.txtKetQua.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(80, 354);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 44);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSub.Location = new System.Drawing.Point(160, 354);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(63, 44);
            this.btnSub.TabIndex = 8;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMult.Location = new System.Drawing.Point(242, 354);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(60, 44);
            this.btnMult.TabIndex = 9;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiv.Location = new System.Drawing.Point(317, 354);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(63, 44);
            this.btnDiv.TabIndex = 10;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(401, 352);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(89, 46);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(508, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 44);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 455);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBai1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÍNH TOÁN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
    }
}