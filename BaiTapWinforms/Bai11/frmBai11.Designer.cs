
namespace Bai11
{
    partial class frmBai11
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwStudent = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.fullName = new System.Windows.Forms.ColumnHeader();
            this.address = new System.Windows.Forms.ColumnHeader();
            this.birth = new System.Windows.Forms.ColumnHeader();
            this.Class = new System.Windows.Forms.ColumnHeader();
            this.cmnuList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.cmnuList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnUpdateItem);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cboClass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpBirth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(57, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(825, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(568, 244);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(175, 50);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(568, 182);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(175, 50);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Xóa Item";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(568, 114);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(175, 50);
            this.btnUpdateItem.TabIndex = 7;
            this.btnUpdateItem.Text = "Cập nhật Item";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(568, 47);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 50);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(213, 303);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(179, 35);
            this.cboClass.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lớp";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(213, 244);
            this.dtpBirth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(179, 35);
            this.dtpBirth.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày sinh";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(213, 182);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(299, 35);
            this.txtAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(213, 118);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(299, 35);
            this.txtFullName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(213, 56);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(299, 35);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // lvwStudent
            // 
            this.lvwStudent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvwStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.fullName,
            this.address,
            this.birth,
            this.Class});
            this.lvwStudent.ContextMenuStrip = this.cmnuList;
            this.lvwStudent.FullRowSelect = true;
            this.lvwStudent.GridLines = true;
            this.lvwStudent.HideSelection = false;
            this.lvwStudent.Location = new System.Drawing.Point(57, 435);
            this.lvwStudent.Name = "lvwStudent";
            this.lvwStudent.Size = new System.Drawing.Size(825, 239);
            this.lvwStudent.TabIndex = 10;
            this.lvwStudent.UseCompatibleStateImageBehavior = false;
            this.lvwStudent.View = System.Windows.Forms.View.Details;
            this.lvwStudent.SelectedIndexChanged += new System.EventHandler(this.lvwStudent_SelectedIndexChanged);
            this.lvwStudent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwStudent_MouseClick);
            // 
            // id
            // 
            this.id.Text = "Mã sinh viên";
            this.id.Width = 150;
            // 
            // fullName
            // 
            this.fullName.Text = "Họ và tên";
            this.fullName.Width = 200;
            // 
            // address
            // 
            this.address.Text = "Địa chỉ";
            this.address.Width = 220;
            // 
            // birth
            // 
            this.birth.Text = "Ngày sinh";
            this.birth.Width = 150;
            // 
            // Class
            // 
            this.Class.Text = "Lớp";
            this.Class.Width = 100;
            // 
            // cmnuList
            // 
            this.cmnuList.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmnuList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmnuList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.cmnuList.Name = "cmnuList";
            this.cmnuList.Size = new System.Drawing.Size(241, 101);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(240, 32);
            this.toolStripMenuItem1.Text = "Large Icon";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(240, 32);
            this.toolStripMenuItem2.Text = "Detail";
            // 
            // frmBai11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 729);
            this.Controls.Add(this.lvwStudent);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBai11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBai11";
            this.Load += new System.EventHandler(this.frmBai11_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cmnuList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvwStudent;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader fullName;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader birth;
        private System.Windows.Forms.ColumnHeader Class;
        private System.Windows.Forms.ContextMenuStrip cmnuList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}