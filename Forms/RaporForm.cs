using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using PersonelYonetimSistemi.Business;
using PersonelYonetimSistemi.Models;
using PersonelYonetimSistemi.Helpers;

namespace PersonelYonetimSistemi.Forms
{
    public partial class RaporForm : Form
    {

        private PersonelYoneticisi yonetici;

        public RaporForm()
        {
            InitializeComponent();
            yonetici = PersonelYoneticisi.Instance;
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            GenelIstatistikGoster();
        }

        private void btnGenelIstatistik_Click(object sender, EventArgs e)
        {
            GenelIstatistikGoster();
        }

        private void btnDepartmanOzeti_Click(object sender, EventArgs e)
        {
            DepartmanOzetiGoster();
        }

        private void btnEnYuksekMaas_Click(object sender, EventArgs e)
        {
            EnYuksekMaasGoster();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GenelIstatistikGoster()
        {
            var istatistik = yonetici.GenelIstatistikRaporu();
            
            txtRapor.Clear();
            txtRapor.AppendText("═══════════════════════════════════════════════\n");
            txtRapor.AppendText("           GENEL İSTATİSTİK RAPORU\n");
            txtRapor.AppendText("═══════════════════════════════════════════════\n\n");
            
            txtRapor.AppendText($"📊 Toplam Personel Sayısı: {istatistik.ToplamPersonel}\n");
            txtRapor.AppendText($"   • Tam Zamanlı: {istatistik.TamZamanliSayisi}\n");
            txtRapor.AppendText($"   • Yarı Zamanlı: {istatistik.YariZamanliSayisi}\n\n");
            
            txtRapor.AppendText($"💰 Maaş Bilgileri:\n");
            txtRapor.AppendText($"   • Toplam Maaş Maliyeti: {istatistik.ToplamMaasMaliyeti:C2}\n");
            txtRapor.AppendText($"   • Ortalama Maaş: {(istatistik.ToplamPersonel > 0 ? istatistik.OrtalamaMaas : 0):C2}\n");
            txtRapor.AppendText($"   • En Yüksek Maaş: {(istatistik.ToplamPersonel > 0 ? istatistik.EnYuksekMaas : 0):C2}\n");
            txtRapor.AppendText($"   • En Düşük Maaş: {(istatistik.ToplamPersonel > 0 ? istatistik.EnDusukMaas : 0):C2}\n\n");
            
            txtRapor.AppendText($"📅 Rapor Tarihi: {DateTime.Now:dd.MM.yyyy HH:mm}\n");
            txtRapor.AppendText("═══════════════════════════════════════════════\n");
        }
        private void DepartmanOzetiGoster()
        {
            var departmanOzetleri = yonetici.DepartmanOzetiRaporu();
            
            txtRapor.Clear();
            txtRapor.AppendText("═══════════════════════════════════════════════\n");
            txtRapor.AppendText("         DEPARTMAN ÖZETİ RAPORU\n");
            txtRapor.AppendText("═══════════════════════════════════════════════\n\n");
            
            if (departmanOzetleri.Count == 0)
            {
                txtRapor.AppendText("Henüz personel bulunmamaktadır.\n");
            }
            else
            {
                foreach (var kvp in departmanOzetleri.OrderByDescending(x => x.Value.PersonelSayisi))
                {
                    var ozet = kvp.Value;
                    
                    txtRapor.AppendText($"🏢 {ozet.Departman}\n");
                    txtRapor.AppendText($"───────────────────────────────────────────────\n");
                    txtRapor.AppendText($"   Personel Sayısı: {ozet.PersonelSayisi}\n");
                    txtRapor.AppendText($"   Toplam Maaş: {ozet.ToplamMaas:C2}\n");
                    txtRapor.AppendText($"   Ortalama Maaş: {ozet.OrtalamaMaas:C2}\n");
                    txtRapor.AppendText($"   En Yüksek Maaş: {ozet.EnYuksekMaas:C2}\n");
                    txtRapor.AppendText($"   En Düşük Maaş: {ozet.EnDusukMaas:C2}\n\n");
                }
            }
            
            txtRapor.AppendText($"📅 Rapor Tarihi: {DateTime.Now:dd.MM.yyyy HH:mm}\n");
            txtRapor.AppendText("═══════════════════════════════════════════════\n");
        }
        private void EnYuksekMaasGoster()
        {
            var personeller = yonetici.EnYuksekMaasRaporu(10);
            
            txtRapor.Clear();
            txtRapor.AppendText("═══════════════════════════════════════════════\n");
            txtRapor.AppendText("       EN YÜKSEK MAAŞLI PERSONELLER\n");
            txtRapor.AppendText("═══════════════════════════════════════════════\n\n");
            
            if (personeller.Count == 0)
            {
                txtRapor.AppendText("Henüz personel bulunmamaktadır.\n");
            }
            else
            {
                int sira = 1;
                foreach (var personel in personeller)
                {
                    txtRapor.AppendText($"{sira}. {personel.TamAd}\n");
                    txtRapor.AppendText($"   ───────────────────────────────────────────\n");
                    txtRapor.AppendText($"   Departman: {personel.Departman}\n");
                    txtRapor.AppendText($"   Personel Tipi: {(personel is TamZamanliPersonel ? "Tam Zamanlı" : "Yarı Zamanlı")}\n");
                    txtRapor.AppendText($"   Temel Maaş: {personel.TemelMaas:C2}\n");
                    txtRapor.AppendText($"   Toplam Maaş: {personel.MaasHesapla():C2}\n");
                    txtRapor.AppendText($"   Çalışma Süresi: {personel.CalismaSuresi} yıl\n");
                    txtRapor.AppendText($"   Detay: {personel.MaasDetayiGetir()}\n\n");
                    sira++;
                }
            }
            
            txtRapor.AppendText($"📅 Rapor Tarihi: {DateTime.Now:dd.MM.yyyy HH:mm}\n");
            txtRapor.AppendText("═══════════════════════════════════════════════\n");
        }
    }
}