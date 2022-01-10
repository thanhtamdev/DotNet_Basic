
namespace Bai13
{
    partial class frmBai13
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nguyen Van Tuan");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nguyen Thi Lan");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nguyen Van Luong");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("THTH5A", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Le Nghiep");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Tran Long");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Ly Hai");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("THTH5B", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Le Trung");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Tran Thi Mai");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Tran Minh");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("THTH5C", 2, 2, new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Khoa tin học", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai13));
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tvKTH = new System.Windows.Forms.TreeView();
            this.imgLists = new System.Windows.Forms.ImageList(this.components);
            this.lvwInfo = new System.Windows.Forms.ListView();
            this.TenSV = new System.Windows.Forms.ColumnHeader();
            this.Lop = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên:";
            // 
            // txtInputName
            // 
            this.txtInputName.Location = new System.Drawing.Point(537, 27);
            this.txtInputName.Name = "txtInputName";
            this.txtInputName.Size = new System.Drawing.Size(233, 35);
            this.txtInputName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(785, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tvKTH
            // 
            this.tvKTH.Cursor = System.Windows.Forms.Cursors.Default;
            this.tvKTH.ImageIndex = 0;
            this.tvKTH.ImageList = this.imgLists;
            this.tvKTH.Location = new System.Drawing.Point(43, 100);
            this.tvKTH.Name = "tvKTH";
            treeNode1.Name = "na1";
            treeNode1.Text = "Nguyen Van Tuan";
            treeNode2.Name = "na2";
            treeNode2.Text = "Nguyen Thi Lan";
            treeNode3.Name = "na3";
            treeNode3.Text = "Nguyen Van Luong";
            treeNode4.Name = "THTH5A";
            treeNode4.SelectedImageIndex = 0;
            treeNode4.Tag = "NodeChild1";
            treeNode4.Text = "THTH5A";
            treeNode5.Name = "nb1";
            treeNode5.Text = "Le Nghiep";
            treeNode6.Name = "nb2";
            treeNode6.Text = "Tran Long";
            treeNode7.Name = "nb3";
            treeNode7.Text = "Ly Hai";
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "THTH5B";
            treeNode8.SelectedImageKey = "snowflake.png";
            treeNode8.Tag = "NodeChild2";
            treeNode8.Text = "THTH5B";
            treeNode9.Name = "nc1";
            treeNode9.Text = "Le Trung";
            treeNode10.Name = "nc2";
            treeNode10.Text = "Tran Thi Mai";
            treeNode11.Name = "nc3";
            treeNode11.Text = "Tran Minh";
            treeNode12.ImageIndex = 2;
            treeNode12.Name = "THTH5C";
            treeNode12.SelectedImageIndex = 2;
            treeNode12.Tag = "NodeChild3";
            treeNode12.Text = "THTH5C";
            treeNode13.Name = "KhoaTinHoc";
            treeNode13.Tag = "Root";
            treeNode13.Text = "Khoa tin học";
            this.tvKTH.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.tvKTH.SelectedImageIndex = 0;
            this.tvKTH.Size = new System.Drawing.Size(345, 450);
            this.tvKTH.TabIndex = 3;
            this.tvKTH.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvKTH_AfterSelect);
            // 
            // imgLists
            // 
            this.imgLists.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgLists.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLists.ImageStream")));
            this.imgLists.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLists.Images.SetKeyName(0, "moon.png");
            this.imgLists.Images.SetKeyName(1, "snowflake.png");
            this.imgLists.Images.SetKeyName(2, "earth.png");
            // 
            // lvwInfo
            // 
            this.lvwInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenSV,
            this.Lop});
            this.lvwInfo.GridLines = true;
            this.lvwInfo.HideSelection = false;
            this.lvwInfo.Location = new System.Drawing.Point(443, 100);
            this.lvwInfo.Name = "lvwInfo";
            this.lvwInfo.Size = new System.Drawing.Size(454, 450);
            this.lvwInfo.TabIndex = 4;
            this.lvwInfo.UseCompatibleStateImageBehavior = false;
            this.lvwInfo.View = System.Windows.Forms.View.Details;
            // 
            // TenSV
            // 
            this.TenSV.Text = "Tên SV";
            this.TenSV.Width = 300;
            // 
            // Lop
            // 
            this.Lop.Text = "Lớp";
            this.Lop.Width = 150;
            // 
            // frmBai13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 604);
            this.Controls.Add(this.lvwInfo);
            this.Controls.Add(this.tvKTH);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtInputName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBai13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBai13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TreeView tvKTH;
        private System.Windows.Forms.ImageList imgLists;
        private System.Windows.Forms.ListView lvwInfo;
        private System.Windows.Forms.ColumnHeader TenSV;
        private System.Windows.Forms.ColumnHeader Lop;
    }
}