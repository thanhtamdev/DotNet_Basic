
namespace Bai6
{
    partial class frmBai6
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
            this.rbPhilipine = new System.Windows.Forms.RadioButton();
            this.rbItalia = new System.Windows.Forms.RadioButton();
            this.rbUSA = new System.Windows.Forms.RadioButton();
            this.rbVietNam = new System.Windows.Forms.RadioButton();
            this.picFlags = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlags)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(195, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "COUNTRY FLAGS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPhilipine);
            this.groupBox1.Controls.Add(this.rbItalia);
            this.groupBox1.Controls.Add(this.rbUSA);
            this.groupBox1.Controls.Add(this.rbVietNam);
            this.groupBox1.Location = new System.Drawing.Point(69, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // rbPhilipine
            // 
            this.rbPhilipine.AutoSize = true;
            this.rbPhilipine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbPhilipine.Location = new System.Drawing.Point(36, 224);
            this.rbPhilipine.Name = "rbPhilipine";
            this.rbPhilipine.Size = new System.Drawing.Size(129, 31);
            this.rbPhilipine.TabIndex = 3;
            this.rbPhilipine.TabStop = true;
            this.rbPhilipine.Text = "Philipine";
            this.rbPhilipine.UseVisualStyleBackColor = true;
            this.rbPhilipine.CheckedChanged += new System.EventHandler(this.rbPhilipine_CheckedChanged);
            // 
            // rbItalia
            // 
            this.rbItalia.AutoSize = true;
            this.rbItalia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbItalia.Location = new System.Drawing.Point(36, 173);
            this.rbItalia.Name = "rbItalia";
            this.rbItalia.Size = new System.Drawing.Size(87, 31);
            this.rbItalia.TabIndex = 2;
            this.rbItalia.TabStop = true;
            this.rbItalia.Text = "Italia";
            this.rbItalia.UseVisualStyleBackColor = true;
            this.rbItalia.CheckedChanged += new System.EventHandler(this.rbItalia_CheckedChanged);
            // 
            // rbUSA
            // 
            this.rbUSA.AutoSize = true;
            this.rbUSA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbUSA.Location = new System.Drawing.Point(36, 123);
            this.rbUSA.Name = "rbUSA";
            this.rbUSA.Size = new System.Drawing.Size(85, 31);
            this.rbUSA.TabIndex = 1;
            this.rbUSA.TabStop = true;
            this.rbUSA.Text = "USA";
            this.rbUSA.UseVisualStyleBackColor = true;
            this.rbUSA.CheckedChanged += new System.EventHandler(this.rbUSA_CheckedChanged);
            // 
            // rbVietNam
            // 
            this.rbVietNam.AutoSize = true;
            this.rbVietNam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbVietNam.Location = new System.Drawing.Point(36, 71);
            this.rbVietNam.Name = "rbVietNam";
            this.rbVietNam.Size = new System.Drawing.Size(134, 31);
            this.rbVietNam.TabIndex = 0;
            this.rbVietNam.TabStop = true;
            this.rbVietNam.Text = "Việt Nam";
            this.rbVietNam.UseVisualStyleBackColor = true;
            this.rbVietNam.CheckedChanged += new System.EventHandler(this.rbVietNam_CheckedChanged);
            // 
            // picFlags
            // 
            this.picFlags.Location = new System.Drawing.Point(373, 221);
            this.picFlags.Name = "picFlags";
            this.picFlags.Size = new System.Drawing.Size(290, 186);
            this.picFlags.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFlags.TabIndex = 2;
            this.picFlags.TabStop = false;
            // 
            // frmBai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 522);
            this.Controls.Add(this.picFlags);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBai6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBai6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPhilipine;
        private System.Windows.Forms.RadioButton rbItalia;
        private System.Windows.Forms.RadioButton rbUSA;
        private System.Windows.Forms.RadioButton rbVietNam;
        private System.Windows.Forms.PictureBox picFlags;
    }
}