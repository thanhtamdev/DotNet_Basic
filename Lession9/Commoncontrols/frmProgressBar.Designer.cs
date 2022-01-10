
namespace Commoncontrols
{
    partial class frmProgressBar
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
            this.prbTinhTong = new System.Windows.Forms.ProgressBar();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prbTinhTong
            // 
            this.prbTinhTong.Location = new System.Drawing.Point(177, 124);
            this.prbTinhTong.Name = "prbTinhTong";
            this.prbTinhTong.Size = new System.Drawing.Size(439, 34);
            this.prbTinhTong.TabIndex = 0;
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(340, 208);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(120, 45);
            this.btnTinhTong.TabIndex = 1;
            this.btnTinhTong.Text = "Tính tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // frmProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 365);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.prbTinhTong);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProgressBar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prbTinhTong;
        private System.Windows.Forms.Button btnTinhTong;
    }
}