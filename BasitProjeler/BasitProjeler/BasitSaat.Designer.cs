namespace BasitProjeler
{
    partial class BasitSaat
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
            this.saat = new System.Windows.Forms.Label();
            this.dakika = new System.Windows.Forms.Label();
            this.saniye = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.Location = new System.Drawing.Point(87, 72);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(32, 36);
            this.saat.TabIndex = 0;
            this.saat.Text = "0";
            // 
            // dakika
            // 
            this.dakika.AutoSize = true;
            this.dakika.Location = new System.Drawing.Point(214, 72);
            this.dakika.Name = "dakika";
            this.dakika.Size = new System.Drawing.Size(32, 36);
            this.dakika.TabIndex = 1;
            this.dakika.Text = "0";
            // 
            // saniye
            // 
            this.saniye.AutoSize = true;
            this.saniye.Location = new System.Drawing.Point(343, 72);
            this.saniye.Name = "saniye";
            this.saniye.Size = new System.Drawing.Size(32, 36);
            this.saniye.TabIndex = 2;
            this.saniye.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BasitSaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 161);
            this.Controls.Add(this.saniye);
            this.Controls.Add(this.dakika);
            this.Controls.Add(this.saat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "BasitSaat";
            this.Text = "BasitSaat";
            this.Load += new System.EventHandler(this.BasitSaat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Label dakika;
        private System.Windows.Forms.Label saniye;
        private System.Windows.Forms.Timer timer1;
    }
}