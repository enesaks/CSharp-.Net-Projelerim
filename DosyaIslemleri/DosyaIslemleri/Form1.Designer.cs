namespace DosyaIslemleri
{
    partial class Form1
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
            this.btnOFD = new System.Windows.Forms.Button();
            this.btnSFD = new System.Windows.Forms.Button();
            this.btnFBD = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnOFD
            // 
            this.btnOFD.Location = new System.Drawing.Point(12, 12);
            this.btnOFD.Name = "btnOFD";
            this.btnOFD.Size = new System.Drawing.Size(377, 63);
            this.btnOFD.TabIndex = 0;
            this.btnOFD.Text = "OpenFileDialog";
            this.btnOFD.UseVisualStyleBackColor = true;
            this.btnOFD.Click += new System.EventHandler(this.btnOFD_Click);
            // 
            // btnSFD
            // 
            this.btnSFD.Location = new System.Drawing.Point(14, 81);
            this.btnSFD.Name = "btnSFD";
            this.btnSFD.Size = new System.Drawing.Size(375, 61);
            this.btnSFD.TabIndex = 1;
            this.btnSFD.Text = "SaveFileDialog";
            this.btnSFD.UseVisualStyleBackColor = true;
            this.btnSFD.Click += new System.EventHandler(this.btnSFD_Click);
            // 
            // btnFBD
            // 
            this.btnFBD.Location = new System.Drawing.Point(14, 148);
            this.btnFBD.Name = "btnFBD";
            this.btnFBD.Size = new System.Drawing.Size(375, 61);
            this.btnFBD.TabIndex = 2;
            this.btnFBD.Text = "FolderBrowserDialog";
            this.btnFBD.UseVisualStyleBackColor = true;
            this.btnFBD.Click += new System.EventHandler(this.btnFBD_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 222);
            this.Controls.Add(this.btnFBD);
            this.Controls.Add(this.btnSFD);
            this.Controls.Add(this.btnOFD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOFD;
        private System.Windows.Forms.Button btnSFD;
        private System.Windows.Forms.Button btnFBD;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

