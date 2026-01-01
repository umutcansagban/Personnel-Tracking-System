using System;
using System.Windows.Forms;

namespace PersonelYonetimSistemi
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var context = new ApplicationContext();
            
            var splashForm = new Forms.SplashForm();
            
            splashForm.FormClosed += (s, e) =>
            {
                var mainForm = new Forms.MainForm();
                context.MainForm = mainForm;
                mainForm.Show();
            };
            
            splashForm.Show();
            Application.Run(context);
        }
    }
}