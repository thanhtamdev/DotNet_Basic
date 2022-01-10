
namespace Bai9
{
    partial class frmBai9
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
            this.txtFulName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstClassA = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstClassB = new System.Windows.Forms.ListBox();
            this.btnMoveAToB = new System.Windows.Forms.Button();
            this.btnMoveAtoBAll = new System.Windows.Forms.Button();
            this.btnMoveBToA = new System.Windows.Forms.Button();
            this.btnMoveBToAAll = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTheEnd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(207, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // txtFulName
            // 
            this.txtFulName.Location = new System.Drawing.Point(232, 124);
            this.txtFulName.Name = "txtFulName";
            this.txtFulName.Size = new System.Drawing.Size(340, 35);
            this.txtFulName.TabIndex = 1;
            this.txtFulName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFulName_KeyDown);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(599, 116);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 48);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstClassA);
            this.groupBox1.Location = new System.Drawing.Point(76, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 383);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // lstClassA
            // 
            this.lstClassA.FormattingEnabled = true;
            this.lstClassA.ItemHeight = 27;
            this.lstClassA.Location = new System.Drawing.Point(26, 56);
            this.lstClassA.Name = "lstClassA";
            this.lstClassA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstClassA.Size = new System.Drawing.Size(236, 301);
            this.lstClassA.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstClassB);
            this.groupBox2.Location = new System.Drawing.Point(476, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 383);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // lstClassB
            // 
            this.lstClassB.FormattingEnabled = true;
            this.lstClassB.ItemHeight = 27;
            this.lstClassB.Location = new System.Drawing.Point(29, 56);
            this.lstClassB.Name = "lstClassB";
            this.lstClassB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstClassB.Size = new System.Drawing.Size(236, 301);
            this.lstClassB.TabIndex = 8;
            // 
            // btnMoveAToB
            // 
            this.btnMoveAToB.Location = new System.Drawing.Point(386, 334);
            this.btnMoveAToB.Name = "btnMoveAToB";
            this.btnMoveAToB.Size = new System.Drawing.Size(73, 38);
            this.btnMoveAToB.TabIndex = 4;
            this.btnMoveAToB.Text = ">";
            this.btnMoveAToB.UseVisualStyleBackColor = true;
            this.btnMoveAToB.Click += new System.EventHandler(this.btnMoveAToB_Click);
            // 
            // btnMoveAtoBAll
            // 
            this.btnMoveAtoBAll.Location = new System.Drawing.Point(386, 389);
            this.btnMoveAtoBAll.Name = "btnMoveAtoBAll";
            this.btnMoveAtoBAll.Size = new System.Drawing.Size(73, 38);
            this.btnMoveAtoBAll.TabIndex = 5;
            this.btnMoveAtoBAll.Text = ">>";
            this.btnMoveAtoBAll.UseVisualStyleBackColor = true;
            this.btnMoveAtoBAll.Click += new System.EventHandler(this.btnMoveAtoBAll_Click);
            // 
            // btnMoveBToA
            // 
            this.btnMoveBToA.Location = new System.Drawing.Point(386, 448);
            this.btnMoveBToA.Name = "btnMoveBToA";
            this.btnMoveBToA.Size = new System.Drawing.Size(73, 38);
            this.btnMoveBToA.TabIndex = 6;
            this.btnMoveBToA.Text = "<";
            this.btnMoveBToA.UseVisualStyleBackColor = true;
            this.btnMoveBToA.Click += new System.EventHandler(this.btnMoveBToA_Click);
            // 
            // btnMoveBToAAll
            // 
            this.btnMoveBToAAll.Location = new System.Drawing.Point(386, 505);
            this.btnMoveBToAAll.Name = "btnMoveBToAAll";
            this.btnMoveBToAAll.Size = new System.Drawing.Size(73, 38);
            this.btnMoveBToAAll.TabIndex = 7;
            this.btnMoveBToAAll.Text = "<<";
            this.btnMoveBToAAll.UseVisualStyleBackColor = true;
            this.btnMoveBToAAll.Click += new System.EventHandler(this.btnMoveBToAAll_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(158, 688);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(141, 42);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTheEnd
            // 
            this.btnTheEnd.Location = new System.Drawing.Point(564, 688);
            this.btnTheEnd.Name = "btnTheEnd";
            this.btnTheEnd.Size = new System.Drawing.Size(141, 42);
            this.btnTheEnd.TabIndex = 10;
            this.btnTheEnd.Text = "Kết thúc";
            this.btnTheEnd.UseVisualStyleBackColor = true;
            this.btnTheEnd.Click += new System.EventHandler(this.btnTheEnd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lớp:";
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(232, 196);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(182, 35);
            this.cboClass.TabIndex = 12;
            // 
            // frmBai9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 751);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTheEnd);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnMoveBToAAll);
            this.Controls.Add(this.btnMoveBToA);
            this.Controls.Add(this.btnMoveAtoBAll);
            this.Controls.Add(this.btnMoveAToB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtFulName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBai9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBai9";
            this.Load += new System.EventHandler(this.frmBai9_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFulName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstClassA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstClassB;
        private System.Windows.Forms.Button btnMoveAToB;
        private System.Windows.Forms.Button btnMoveAtoBAll;
        private System.Windows.Forms.Button btnMoveBToA;
        private System.Windows.Forms.Button btnMoveBToAAll;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTheEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboClass;
    }
}