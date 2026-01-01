using System;
using System.Text.RegularExpressions;

namespace PersonelYonetimSistemi.Helpers
{
    public static class ValidationHelper
    {
        /// <summary>
        /// TCKimlikNoGecerliMi metodu
        /// </summary>
        public static bool TCKimlikNoGecerliMi(string tcKimlikNo)
        {
            if (string.IsNullOrWhiteSpace(tcKimlikNo))
                return false;
            if (tcKimlikNo.Length != 11)
                return false;
            foreach (char c in tcKimlikNo)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            if (tcKimlikNo[0] == '0')
                return false;

            return true;
        }
        /// <summary>
        /// EmailGecerliMi metodu
        /// </summary>
        public static bool EmailGecerliMi(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern);
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// TelefonGecerliMi metodu
        /// </summary>
        public static bool TelefonGecerliMi(string telefon)
        {
            if (string.IsNullOrWhiteSpace(telefon))
                return false;
            string sadeceSayilar = Regex.Replace(telefon, @"[^\d]", "");
            return sadeceSayilar.Length == 10 || sadeceSayilar.Length == 11;
        }
        /// <summary>
        /// TarihAraligiGecerliMi metodu
        /// </summary>
        public static bool TarihAraligiGecerliMi(DateTime baslangic, DateTime bitis)
        {
            return baslangic <= bitis;
        }
        /// <summary>
        /// SayiAraligindaMi metodu
        /// </summary>
        public static bool SayiAraligindaMi(decimal deger, decimal min, decimal max)
        {
            return deger >= min && deger <= max;
        }
        /// <summary>
        /// MetinGecerliMi metodu
        /// </summary>
        public static bool MetinGecerliMi(string metin, int minUzunluk = 1)
        {
            if (string.IsNullOrWhiteSpace(metin))
                return false;

            return metin.Trim().Length >= minUzunluk;
        }
    }
}