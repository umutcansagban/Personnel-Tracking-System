namespace PersonelYonetimSistemi.Forms
{
    partial class SplashForm
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblYukleniyor = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::PersonelYonetimSistemi.Properties.Resources.denemelogo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(248, 35);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(306, 260);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(100, 308);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(493, 41);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "Personel ve Maaş Yönetim Sistemi";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYukleniyor
            // 
            this.lblYukleniyor.AutoSize = true;
            this.lblYukleniyor.BackColor = System.Drawing.Color.Transparent;
            this.lblYukleniyor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblYukleniyor.ForeColor = System.Drawing.Color.White;
            this.lblYukleniyor.Location = new System.Drawing.Point(320, 394);
            this.lblYukleniyor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYukleniyor.Name = "lblYukleniyor";
            this.lblYukleniyor.Size = new System.Drawing.Size(128, 23);
            this.lblYukleniyor.TabIndex = 2;
            this.lblYukleniyor.Text = "Yükleniyor... %0";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(200, 431);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(400, 12);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 3;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblYukleniyor);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yükleniyor...";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SplashForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblYukleniyor;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}