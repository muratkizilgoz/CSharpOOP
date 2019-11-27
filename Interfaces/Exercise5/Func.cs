using System;

namespace Exercise5
{
    public class Func
    {
        public static void SiparisConsolaYazdir(Siparis siparis)
        {
            Console.WriteLine($"Siparis no: {siparis.SiparisNo} Alıcı Adı: {siparis.AliciAdi} Toplam Fiyat: {siparis.ToplamFiyat} Adres: {siparis.Adres}");
        }
    }
}