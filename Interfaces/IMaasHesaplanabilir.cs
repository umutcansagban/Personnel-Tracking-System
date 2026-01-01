using System;

namespace PersonelYonetimSistemi.Interfaces
{
    /// <summary>
    /// IMaasHesaplanabilir sýnýfý
    /// </summary>
        /// <summary>
        ///  property
        /// </summary>
    public interface IMaasHesaplanabilir
    {
        decimal MaasHesapla();

        string MaasDetayiGetir();
    }
}