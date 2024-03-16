namespace Proje_Hastane
{
    partial class FrmGirisler
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
            this.btnHasta = new System.Windows.Forms.Button();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.btnSekreter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHasta
            // 
            this.btnHasta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHasta.Location = new System.Drawing.Point(12, 12);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(263, 206);
            this.btnHasta.TabIndex = 0;
            this.btnHasta.Text = "Hatsa";
            this.btnHasta.UseVisualStyleBackColor = false;
            // 
            // btnDoktor
            // 
            this.btnDoktor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDoktor.Location = new System.Drawing.Point(277, 12);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(263, 206);
            this.btnDoktor.TabIndex = 1;
            this.btnDoktor.Text = "Doktor";
            this.btnDoktor.UseVisualStyleBackColor = false;
            // 
            // btnSekreter
            // 
            this.btnSekreter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSekreter.Location = new System.Drawing.Point(546, 12);
            this.btnSekreter.Name = "btnSekreter";
            this.btnSekreter.Size = new System.Drawing.Size(263, 206);
            this.btnSekreter.TabIndex = 2;
            this.btnSekreter.Text = "Sekreter";
            this.btnSekreter.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 229);
            this.Controls.Add(this.btnSekreter);
            this.Controls.Add(this.btnDoktor);
            this.Controls.Add(this.btnHasta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.Button btnDoktor;
        private System.Windows.Forms.Button btnSekreter;
    }
}

