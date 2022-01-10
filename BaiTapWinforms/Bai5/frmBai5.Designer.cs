
namespace Bai5
{
    partial class frmBai5
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
            this.btnExit = new System.Windows.Forms.Button();
            this.rbTimeNewRoman = new System.Windows.Forms.RadioButton();
            this.rbArial = new System.Windows.Forms.RadioButton();
            this.rbTahoma = new System.Windows.Forms.RadioButton();
            this.rbCourierNew = new System.Windows.Forms.RadioButton();
            this.txtVB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập văn bản:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(366, 481);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 52);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbTimeNewRoman
            // 
            this.rbTimeNewRoman.AutoSize = true;
            this.rbTimeNewRoman.Location = new System.Drawing.Point(539, 163);
            this.rbTimeNewRoman.Name = "rbTimeNewRoman";
            this.rbTimeNewRoman.Size = new System.Drawing.Size(228, 36);
            this.rbTimeNewRoman.TabIndex = 4;
            this.rbTimeNewRoman.TabStop = true;
            this.rbTimeNewRoman.Text = "Time New Roman";
            this.rbTimeNewRoman.UseVisualStyleBackColor = true;
            this.rbTimeNewRoman.CheckedChanged += new System.EventHandler(this.rbTimeNewRoman_CheckedChanged);
            // 
            // rbArial
            // 
            this.rbArial.AutoSize = true;
            this.rbArial.Location = new System.Drawing.Point(539, 218);
            this.rbArial.Name = "rbArial";
            this.rbArial.Size = new System.Drawing.Size(86, 36);
            this.rbArial.TabIndex = 5;
            this.rbArial.TabStop = true;
            this.rbArial.Text = "Arial";
            this.rbArial.UseVisualStyleBackColor = true;
            this.rbArial.CheckedChanged += new System.EventHandler(this.rbArial_CheckedChanged);
            // 
            // rbTahoma
            // 
            this.rbTahoma.AutoSize = true;
            this.rbTahoma.Location = new System.Drawing.Point(539, 271);
            this.rbTahoma.Name = "rbTahoma";
            this.rbTahoma.Size = new System.Drawing.Size(122, 36);
            this.rbTahoma.TabIndex = 6;
            this.rbTahoma.TabStop = true;
            this.rbTahoma.Text = "Tahoma";
            this.rbTahoma.UseVisualStyleBackColor = true;
            this.rbTahoma.CheckedChanged += new System.EventHandler(this.rbTahoma_CheckedChanged);
            // 
            // rbCourierNew
            // 
            this.rbCourierNew.AutoSize = true;
            this.rbCourierNew.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCourierNew.Location = new System.Drawing.Point(539, 325);
            this.rbCourierNew.Name = "rbCourierNew";
            this.rbCourierNew.Size = new System.Drawing.Size(160, 34);
            this.rbCourierNew.TabIndex = 7;
            this.rbCourierNew.TabStop = true;
            this.rbCourierNew.Text = "Courier New";
            this.rbCourierNew.UseVisualStyleBackColor = true;
            this.rbCourierNew.CheckedChanged += new System.EventHandler(this.rbCourierNew_CheckedChanged);
            // 
            // txtVB
            // 
            this.txtVB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtVB.Location = new System.Drawing.Point(74, 125);
            this.txtVB.Multiline = true;
            this.txtVB.Name = "txtVB";
            this.txtVB.Size = new System.Drawing.Size(400, 304);
            this.txtVB.TabIndex = 8;
            this.txtVB.Text = "WHAT FONT IS THIS?";
            // 
            // frmBai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 576);
            this.Controls.Add(this.txtVB);
            this.Controls.Add(this.rbCourierNew);
            this.Controls.Add(this.rbTahoma);
            this.Controls.Add(this.rbArial);
            this.Controls.Add(this.rbTimeNewRoman);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBai5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbTimeNewRoman;
        private System.Windows.Forms.RadioButton rbArial;
        private System.Windows.Forms.RadioButton rbTahoma;
        private System.Windows.Forms.RadioButton rbCourierNew;
        private System.Windows.Forms.TextBox txtVB;
    }
}