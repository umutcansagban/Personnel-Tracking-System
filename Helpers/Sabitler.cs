namespace PersonelYonetimSistemi.Helpers
{
    public static class Sabitler
    {
        public static readonly decimal MinimumMaas = 17002m;

        public static readonly decimal MaksimumMaas = 500000m;

        public static readonly decimal VarsayilanSigortaOrani = 0.14m;

        public static readonly decimal MinimumSaatlikUcret = 100m;

        public static readonly string PrimaryColor = "#2C3E50";

        public static readonly string SecondaryColor = "#3498DB";

        public static readonly string AccentColor = "#E74C3C";

        public static readonly string SuccessColor = "#27AE60";

        public static readonly string WarningColor = "#F39C12";

        public static readonly string HataBaslik = "Hata";
        public static readonly string UyariBaslik = "Uyarı";
        public static readonly string BilgiBaslik = "Bilgi";
        public static readonly string BasariBaslik = "Başarı";

        public static readonly string PersonelEklendi = "Personel başarıyla eklendi!";
        public static readonly string PersonelGuncellendi = "Personel başarıyla güncellendi!";
        public static readonly string PersonelSilindi = "Personel başarıyla silindi!";
        public static readonly string PersonelBulunamadi = "Personel bulunamadı!";
        public static readonly string TCKimlikMevcut = "Bu TC Kimlik No ile kayıtlı personel zaten mevcut!";
    }
}