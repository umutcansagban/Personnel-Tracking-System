using System;

namespace PersonelYonetimSistemi.Models
{
    /// <summary>
    /// TamZamanliPersonel sýnýfý
    /// </summary>
    public class TamZamanliPersonel : Personel
    {
        private decimal _prim;
        private decimal _sigortaKesintisi;

        /// <summary>
        ///  property
        /// </summary>
        public decimal Prim
        {
            get { return _prim; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Prim negatif olamaz!");
                }
                _prim = value;
            }
        }

        /// <summary>
        ///  property
        /// </summary>
        public decimal SigortaKesintisi
        {
            get { return _sigortaKesintisi; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Sigorta kesintisi negatif olamaz!");
                }
                _sigortaKesintisi = value;
            }
        }

        public TamZamanliPersonel(int id, string ad, string soyad, string tcKimlikNo,
                                  Departman departman, decimal temelMaas, DateTime iseGirisTarihi,
                                  decimal prim, decimal sigortaKesintisi)
            : base(id, ad, soyad, tcKimlikNo, departman, temelMaas, iseGirisTarihi)
        {
            this.Prim = prim;
            this.SigortaKesintisi = sigortaKesintisi;
        }

        public TamZamanliPersonel(int id, string ad, string soyad, string tcKimlikNo,
                                  Departman departman, decimal temelMaas, DateTime iseGirisTarihi)
            : this(id, ad, soyad, tcKimlikNo, departman, temelMaas, iseGirisTarihi, 0, 0)
        {
        }

        public TamZamanliPersonel(int id, string ad, string soyad, string tcKimlikNo,
                                  Departman departman, decimal temelMaas, DateTime iseGirisTarihi,
                                  decimal sigortaKesintisi)
            : this(id, ad, soyad, tcKimlikNo, departman, temelMaas, iseGirisTarihi, 0, sigortaKesintisi)
        {
        }

        /// <summary>
        /// MaasHesapla metodu
        /// </summary>
        public override decimal MaasHesapla()
        {
            return TemelMaas + Prim - SigortaKesintisi;
        }

        /// <summary>
        /// MaasDetayiGetir metodu
        /// </summary>
        public override string MaasDetayiGetir()
        {
            return $"Temel MaaÅŸ: {TemelMaas:C2} + Prim: {Prim:C2} - Sigorta: {SigortaKesintisi:C2} = {MaasHesapla():C2}";
        }

        /// <summary>
        /// RaporOlustur metodu
        /// </summary>
        public override string RaporOlustur()
        {
            string temelRapor = base.RaporOlustur();
            return $"{temelRapor}\n" +
                   $"Personel Tipi: Tam ZamanlÄ±\n" +
                   $"Prim: {Prim:C2}\n" +
                   $"Sigorta Kesintisi: {SigortaKesintisi:C2}";
        }

        /// <summary>
        /// ToString metodu
        /// </summary>
        public override string ToString()
        {
            return $"{base.ToString()} - Tam ZamanlÄ± - MaaÅŸ: {MaasHesapla():C2}";
        }
    }
}