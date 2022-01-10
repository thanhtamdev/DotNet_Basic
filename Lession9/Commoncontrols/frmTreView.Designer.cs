
namespace Commoncontrols
{
    partial class frmTreView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Đại học Đại Nam");
            this.treKhoa = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treKhoa
            // 
            this.treKhoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.treKhoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.treKhoa.Location = new System.Drawing.Point(0, 0);
            this.treKhoa.Name = "treKhoa";
            treeNode1.Name = "DaiHocDaiNam";
            treeNode1.Text = "Đại học Đại Nam";
            this.treKhoa.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treKhoa.Size = new System.Drawing.Size(281, 613);
            this.treKhoa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên khoa:";
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(472, 47);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(268, 35);
            this.txtTenKhoa.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(332, 116);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 50);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmTreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 613);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treKhoa);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmTreView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTreView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Button btnThem;
    }
}