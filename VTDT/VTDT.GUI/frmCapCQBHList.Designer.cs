
namespace VTDT.GUI
{
    partial class frmCapCQBHList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapCQBHList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThemMoi = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvCapCQBH = new System.Windows.Forms.DataGridView();
            this.MaCapCQBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCapCQBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapCQBH)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemMoi,
            this.btnSua,
            this.toolStripSeparator1,
            this.btnXoa,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1156, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(120, 29);
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 29);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 29);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // dgvCapCQBH
            // 
            this.dgvCapCQBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapCQBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCapCQBH,
            this.TenCapCQBH,
            this.GhiChu});
            this.dgvCapCQBH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCapCQBH.Location = new System.Drawing.Point(0, 34);
            this.dgvCapCQBH.Name = "dgvCapCQBH";
            this.dgvCapCQBH.RowHeadersWidth = 62;
            this.dgvCapCQBH.RowTemplate.Height = 28;
            this.dgvCapCQBH.Size = new System.Drawing.Size(1156, 573);
            this.dgvCapCQBH.TabIndex = 1;
            // 
            // MaCapCQBH
            // 
            this.MaCapCQBH.DataPropertyName = "MaCapCQBH";
            this.MaCapCQBH.HeaderText = "Mã cấp CQBH";
            this.MaCapCQBH.MinimumWidth = 8;
            this.MaCapCQBH.Name = "MaCapCQBH";
            this.MaCapCQBH.Width = 250;
            // 
            // TenCapCQBH
            // 
            this.TenCapCQBH.DataPropertyName = "TenCapCQBH";
            this.TenCapCQBH.HeaderText = "Tên cấp CQBH";
            this.TenCapCQBH.MinimumWidth = 8;
            this.TenCapCQBH.Name = "TenCapCQBH";
            this.TenCapCQBH.Width = 250;
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 8;
            this.GhiChu.Name = "GhiChu";
            // 
            // frmCapCQBHList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 607);
            this.Controls.Add(this.dgvCapCQBH);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCapCQBHList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách cấp cơ quan ban hành";
            this.Load += new System.EventHandler(this.frmCapCQBHList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapCQBH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThemMoi;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dgvCapCQBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCapCQBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCapCQBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}