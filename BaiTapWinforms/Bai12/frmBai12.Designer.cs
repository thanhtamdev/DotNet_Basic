
namespace Bai12
{
    partial class frmBai12
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOldNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConsume = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIntoMoney = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lvwInfo = new System.Windows.Forms.ListView();
            this.HoTen = new System.Windows.Forms.ColumnHeader();
            this.KhuVuc = new System.Windows.Forms.ColumnHeader();
            this.DinhMuc = new System.Windows.Forms.ColumnHeader();
            this.TieuThu = new System.Windows.Forms.ColumnHeader();
            this.ThanhTien = new System.Windows.Forms.ColumnHeader();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO THU TIỀN ĐIỆN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên KH:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(167, 123);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(328, 35);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Khu vực:";
            // 
            // cboRegion
            // 
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(167, 180);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(328, 35);
            this.cboRegion.TabIndex = 2;
            this.cboRegion.SelectedIndexChanged += new System.EventHandler(this.cboRegion_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Định mức:";
            // 
            // txtQuota
            // 
            this.txtQuota.Location = new System.Drawing.Point(167, 240);
            this.txtQuota.Name = "txtQuota";
            this.txtQuota.ReadOnly = true;
            this.txtQuota.Size = new System.Drawing.Size(328, 35);
            this.txtQuota.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số cũ:";
            // 
            // txtOldNum
            // 
            this.txtOldNum.Location = new System.Drawing.Point(167, 298);
            this.txtOldNum.Name = "txtOldNum";
            this.txtOldNum.Size = new System.Drawing.Size(328, 35);
            this.txtOldNum.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số mới:";
            // 
            // txtNewNum
            // 
            this.txtNewNum.Location = new System.Drawing.Point(167, 358);
            this.txtNewNum.Name = "txtNewNum";
            this.txtNewNum.Size = new System.Drawing.Size(328, 35);
            this.txtNewNum.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tiêu thụ:";
            // 
            // txtConsume
            // 
            this.txtConsume.Location = new System.Drawing.Point(167, 419);
            this.txtConsume.Name = "txtConsume";
            this.txtConsume.ReadOnly = true;
            this.txtConsume.Size = new System.Drawing.Size(328, 35);
            this.txtConsume.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 27);
            this.label8.TabIndex = 13;
            this.label8.Text = "Thành tiền:";
            // 
            // txtIntoMoney
            // 
            this.txtIntoMoney.Location = new System.Drawing.Point(165, 474);
            this.txtIntoMoney.Name = "txtIntoMoney";
            this.txtIntoMoney.ReadOnly = true;
            this.txtIntoMoney.Size = new System.Drawing.Size(330, 35);
            this.txtIntoMoney.TabIndex = 14;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(49, 548);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 51);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Tính tiền";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(206, 548);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(130, 51);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Nhập mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(365, 548);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 51);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lvwInfo
            // 
            this.lvwInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HoTen,
            this.KhuVuc,
            this.DinhMuc,
            this.TieuThu,
            this.ThanhTien});
            this.lvwInfo.FullRowSelect = true;
            this.lvwInfo.GridLines = true;
            this.lvwInfo.HideSelection = false;
            this.lvwInfo.Location = new System.Drawing.Point(539, 47);
            this.lvwInfo.MultiSelect = false;
            this.lvwInfo.Name = "lvwInfo";
            this.lvwInfo.Size = new System.Drawing.Size(699, 462);
            this.lvwInfo.TabIndex = 8;
            this.lvwInfo.UseCompatibleStateImageBehavior = false;
            this.lvwInfo.View = System.Windows.Forms.View.Details;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ tên";
            this.HoTen.Width = 200;
            // 
            // KhuVuc
            // 
            this.KhuVuc.Text = "Khu vực";
            this.KhuVuc.Width = 125;
            // 
            // DinhMuc
            // 
            this.DinhMuc.Text = "Định mức";
            this.DinhMuc.Width = 120;
            // 
            // TieuThu
            // 
            this.TieuThu.Text = "Tiêu thụ";
            this.TieuThu.Width = 120;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Text = "Thành tiền";
            this.ThanhTien.Width = 130;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(539, 560);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 27);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tổng tiền:";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(654, 557);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(262, 35);
            this.txtSum.TabIndex = 20;
            this.txtSum.Text = "0";
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(1125, 526);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(113, 52);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // frmBai12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 626);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lvwInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtIntoMoney);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtConsume);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNewNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOldNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboRegion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBai12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính tiền điện";
            this.Load += new System.EventHandler(this.frmBai12_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBai12_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOldNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNewNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConsume;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIntoMoney;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView lvwInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader KhuVuc;
        private System.Windows.Forms.ColumnHeader DinhMuc;
        private System.Windows.Forms.ColumnHeader TieuThu;
        private System.Windows.Forms.ColumnHeader ThanhTien;
    }
}