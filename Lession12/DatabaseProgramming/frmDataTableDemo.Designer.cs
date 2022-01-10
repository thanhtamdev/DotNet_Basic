
namespace DatabaseProgramming
{
    partial class frmDataTableDemo
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
            this.lvwKhoa = new System.Windows.Forms.ListView();
            this.MaKhoa = new System.Windows.Forms.ColumnHeader();
            this.TenKhoa = new System.Windows.Forms.ColumnHeader();
            this.DienThoai = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvwKhoa
            // 
            this.lvwKhoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaKhoa,
            this.TenKhoa,
            this.DienThoai});
            this.lvwKhoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvwKhoa.GridLines = true;
            this.lvwKhoa.HideSelection = false;
            this.lvwKhoa.Location = new System.Drawing.Point(0, 147);
            this.lvwKhoa.Name = "lvwKhoa";
            this.lvwKhoa.Size = new System.Drawing.Size(800, 303);
            this.lvwKhoa.TabIndex = 0;
            this.lvwKhoa.UseCompatibleStateImageBehavior = false;
            this.lvwKhoa.View = System.Windows.Forms.View.Details;
            // 
            // MaKhoa
            // 
            this.MaKhoa.Text = "Mã khoa";
            this.MaKhoa.Width = 250;
            // 
            // TenKhoa
            // 
            this.TenKhoa.Text = "Tên Khoa";
            this.TenKhoa.Width = 200;
            // 
            // DienThoai
            // 
            this.DienThoai.Text = "Số điện thoại";
            this.DienThoai.Width = 200;
            // 
            // frmDataTableDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvwKhoa);
            this.Name = "frmDataTableDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDataTableDemo";
            this.Load += new System.EventHandler(this.frmDataTableDemo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwKhoa;
        private System.Windows.Forms.ColumnHeader MaKhoa;
        private System.Windows.Forms.ColumnHeader TenKhoa;
        private System.Windows.Forms.ColumnHeader DienThoai;
    }
}