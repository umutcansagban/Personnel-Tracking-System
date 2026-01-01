using System;

namespace PersonelYonetimSistemi.Models
{
    /// <summary>
    /// YariZamanliPersonel s�n�f�
    /// </summary>
    public class YariZamanliPersonel : Personel
    {
        private decimal _saatlikUcret;
        private int _calisilanSaat;

        /// <summary>
        ///  property
        /// </summary>
        public decimal SaatlikUcret
        {
            get { return _saatlikUcret; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Saatlik ücret negatif olamaz!");
                }
                if (value < 100)
                {
                    throw new ArgumentException("Saatlik ücret minimum 100 TL olmalıdır!");
                }
                _saatlikUcret = value;
            }
        }

        /// <summary>
        ///  property
        /// </summary>
        public int CalisilanSaat
        {
            get { return _calisilanSaat; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Çalışılan saat negatif olamaz!");
                }
                if (value > 200)
                {
                    throw new ArgumentException("Çalışılan saat ayda maksimum 200 saat olabilir!");
                }
                _calisilanSaat = value;
            }
        }

        public YariZamanliPersonel(int id, string ad, string soyad, string tcKimlikNo,
                                   Departman departman, decimal temelMaas, DateTime iseGirisTarihi,
                                   decimal saatlikUcret, int calisilanSaat)
            : base(id, ad, soyad, tcKimlikNo, departman, temelMaas, iseGirisTarihi)
        {
            this.SaatlikUcret = saatlikUcret;
            this.CalisilanSaat = calisilanSaat;
        }

        public YariZamanliPersonel(int id, string ad, string soyad, string tcKimlikNo,
                                   Departman departman, decimal temelMaas, DateTime iseGirisTarihi,
                                   decimal saatlikUcret)
            : this(id, ad, soyad, tcKimlikNo, departman, temelMaas, iseGirisTarihi, saatlikUcret, 0)
        {
        }

        /// <summary>
        /// MaasHesapla metodu
        /// </summary>
        public override decimal MaasHesapla()
        {
            return TemelMaas + (SaatlikUcret * CalisilanSaat);
        }

        /// <summary>
        /// MaasDetayiGetir metodu
        /// </summary>
        public override string MaasDetayiGetir()
        {
            decimal ekUcret = SaatlikUcret * CalisilanSaat;
            return $"Temel Maaş: {TemelMaas:C2} + ({SaatlikUcret:C2} × {CalisilanSaat} saat) = {MaasHesapla():C2}";
        }

        /// <summary>
        /// RaporOlustur metodu
        /// </summary>
        public override string RaporOlustur()
        {
            string temelRapor = base.RaporOlustur();
            return $"{temelRapor}\n" +
                   $"Personel Tipi: Yarı Zamanlı\n" +
                   $"Saatlik Ücret: {SaatlikUcret:C2}\n" +
                   $"Çalışılan Saat: {CalisilanSaat} saat\n" +
                   $"Ek Ücret: {(SaatlikUcret * CalisilanSaat):C2}";
        }

        /// <summary>
        /// ToString metodu
        /// </summary>
        public override string ToString()
        {
            return $"{base.ToString()} - Yarı Zamanlı - Maaş: {MaasHesapla():C2}";
        }
    }
}