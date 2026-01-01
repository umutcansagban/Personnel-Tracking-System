using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using PersonelYonetimSistemi.Helpers;

namespace PersonelYonetimSistemi.Forms
{
    public partial class SplashForm : Form
    {
        private Timer animasyonTimer;
        private double animasyonAdimi = 0;
        private double logoOpacity = 0;
        private int progressDegeri = 0;

        public SplashForm()
        {
            InitializeComponent();
            
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | 
                         ControlStyles.AllPaintingInWmPaint | 
                         ControlStyles.UserPaint, true);
            this.UpdateStyles();
            
            AnimasyonuBaslat();
        }

        private void AnimasyonuBaslat()
        {
            animasyonTimer = new Timer();
            animasyonTimer.Interval = 32;
            animasyonTimer.Tick += AnimasyonTimer_Tick;
            animasyonTimer.Start();
        }

        private void AnimasyonTimer_Tick(object sender, EventArgs e)
        {
            animasyonAdimi += 0.5;

            if (animasyonAdimi <= 30)
            {
                logoOpacity = EaseInOutQuad(animasyonAdimi / 30.0);
                this.Opacity = logoOpacity;
            }
            else if (animasyonAdimi <= 90)
            {
                progressDegeri = (int)(EaseInOutQuad((animasyonAdimi - 30) / 60.0) * 100);
                progressBar.Value = progressDegeri;
                lblYukleniyor.Text = $"Yükleniyor... %{progressDegeri}";
            }
            else if (animasyonAdimi <= 105)
            {
                double fadeOut = 1.0 - EaseInOutQuad((animasyonAdimi - 90) / 15.0);
                this.Opacity = fadeOut;
            }
            else
            {
                animasyonTimer.Stop();
                animasyonTimer.Dispose();
                this.Close();
            }

            this.Invalidate();
        }

        private double EaseInOutQuad(double t)
        {
            return t < 0.5 ? 2 * t * t : 1 - Math.Pow(-2 * t + 2, 2) / 2;
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }

        private void SplashForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                ColorTranslator.FromHtml(Sabitler.PrimaryColor),
                ColorTranslator.FromHtml(Sabitler.SecondaryColor),
                45f))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}