
namespace Bai8
{
    partial class frmBai8
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChonSoLe = new System.Windows.Forms.Button();
            this.btnChonSoChan = new System.Windows.Forms.Button();
            this.btnSubstitute = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnDelSelect = new System.Windows.Forms.Button();
            this.btnDelHeadTail = new System.Windows.Forms.Button();
            this.btnSumAll = new System.Windows.Forms.Button();
            this.btnTheEnd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(282, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTBOX";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.lstSo);
            this.groupBox1.Controls.Add(this.btnNhap);
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Location = new System.Drawing.Point(45, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 520);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listbox";
            // 
            // lstSo
            // 
            this.lstSo.FormattingEnabled = true;
            this.lstSo.ItemHeight = 27;
            this.lstSo.Location = new System.Drawing.Point(25, 170);
            this.lstSo.Name = "lstSo";
            this.lstSo.ScrollAlwaysVisible = true;
            this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSo.Size = new System.Drawing.Size(214, 328);
            this.lstSo.TabIndex = 3;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(25, 99);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(214, 55);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(25, 43);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(214, 35);
            this.txtNhap.TabIndex = 1;
            this.txtNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhap_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.Controls.Add(this.btnChonSoLe);
            this.groupBox2.Controls.Add(this.btnChonSoChan);
            this.groupBox2.Controls.Add(this.btnSubstitute);
            this.groupBox2.Controls.Add(this.btnAdd2);
            this.groupBox2.Controls.Add(this.btnDelSelect);
            this.groupBox2.Controls.Add(this.btnDelHeadTail);
            this.groupBox2.Controls.Add(this.btnSumAll);
            this.groupBox2.Location = new System.Drawing.Point(351, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 520);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xử lí Listbox";
            // 
            // btnChonSoLe
            // 
            this.btnChonSoLe.Location = new System.Drawing.Point(17, 449);
            this.btnChonSoLe.Name = "btnChonSoLe";
            this.btnChonSoLe.Size = new System.Drawing.Size(297, 49);
            this.btnChonSoLe.TabIndex = 10;
            this.btnChonSoLe.Text = "Chọn số lẻ";
            this.btnChonSoLe.UseVisualStyleBackColor = true;
            this.btnChonSoLe.Click += new System.EventHandler(this.btnChonSoLe_Click);
            // 
            // btnChonSoChan
            // 
            this.btnChonSoChan.Location = new System.Drawing.Point(17, 379);
            this.btnChonSoChan.Name = "btnChonSoChan";
            this.btnChonSoChan.Size = new System.Drawing.Size(297, 49);
            this.btnChonSoChan.TabIndex = 9;
            this.btnChonSoChan.Text = "Chọn số chẵn";
            this.btnChonSoChan.UseVisualStyleBackColor = true;
            this.btnChonSoChan.Click += new System.EventHandler(this.btnChonSoChan_Click);
            // 
            // btnSubstitute
            // 
            this.btnSubstitute.Location = new System.Drawing.Point(17, 312);
            this.btnSubstitute.Name = "btnSubstitute";
            this.btnSubstitute.Size = new System.Drawing.Size(297, 49);
            this.btnSubstitute.TabIndex = 8;
            this.btnSubstitute.Text = "Thay bằng bình phương";
            this.btnSubstitute.UseVisualStyleBackColor = true;
            this.btnSubstitute.Click += new System.EventHandler(this.btnSubstitute_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(17, 242);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(297, 49);
            this.btnAdd2.TabIndex = 7;
            this.btnAdd2.Text = "Tăng mỗi phần tử lên 2";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnDelSelect
            // 
            this.btnDelSelect.Location = new System.Drawing.Point(17, 173);
            this.btnDelSelect.Name = "btnDelSelect";
            this.btnDelSelect.Size = new System.Drawing.Size(297, 49);
            this.btnDelSelect.TabIndex = 6;
            this.btnDelSelect.Text = "Xóa phần tử đang chọn";
            this.btnDelSelect.UseVisualStyleBackColor = true;
            this.btnDelSelect.Click += new System.EventHandler(this.btnDelSelect_Click);
            // 
            // btnDelHeadTail
            // 
            this.btnDelHeadTail.Location = new System.Drawing.Point(17, 105);
            this.btnDelHeadTail.Name = "btnDelHeadTail";
            this.btnDelHeadTail.Size = new System.Drawing.Size(297, 49);
            this.btnDelHeadTail.TabIndex = 5;
            this.btnDelHeadTail.Text = "Xóa phần tử đầu và cuối";
            this.btnDelHeadTail.UseVisualStyleBackColor = true;
            this.btnDelHeadTail.Click += new System.EventHandler(this.btnDelHeadTail_Click);
            // 
            // btnSumAll
            // 
            this.btnSumAll.Location = new System.Drawing.Point(17, 35);
            this.btnSumAll.Name = "btnSumAll";
            this.btnSumAll.Size = new System.Drawing.Size(297, 49);
            this.btnSumAll.TabIndex = 4;
            this.btnSumAll.Text = "Tổng các phần tử trong List";
            this.btnSumAll.UseVisualStyleBackColor = true;
            this.btnSumAll.Click += new System.EventHandler(this.btnSumAll_Click);
            // 
            // btnTheEnd
            // 
            this.btnTheEnd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTheEnd.Location = new System.Drawing.Point(45, 655);
            this.btnTheEnd.Name = "btnTheEnd";
            this.btnTheEnd.Size = new System.Drawing.Size(636, 49);
            this.btnTheEnd.TabIndex = 11;
            this.btnTheEnd.Text = "Kết thúc";
            this.btnTheEnd.UseVisualStyleBackColor = true;
            this.btnTheEnd.Click += new System.EventHandler(this.btnTheEnd_Click);
            // 
            // frmBai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 729);
            this.Controls.Add(this.btnTheEnd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBai8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBai8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSubstitute;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnDelSelect;
        private System.Windows.Forms.Button btnDelHeadTail;
        private System.Windows.Forms.Button btnSumAll;
        private System.Windows.Forms.Button btnChonSoLe;
        private System.Windows.Forms.Button btnChonSoChan;
        private System.Windows.Forms.Button btnTheEnd;
    }
}