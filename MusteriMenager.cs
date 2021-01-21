using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriMenager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri no: " + musteri.Id+ " Adınız: "+musteri.Ad+" Soyadınız: "+musteri.Soyad+" Tc kimlik numaranız: "+musteri.TcNo+" Kaydınız tamamlandı.");
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Müşteri no: " + musteri.Id + " Adınız: " + musteri.Ad + " Soyadınız: " + musteri.Soyad + " Tc kimlik numaranız: " + musteri.TcNo + " Kaydınız silindi.");

        }
        public void MusteriBilgileriGuncelleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri no: " + musteri.Id + " Adınız: " + musteri.Ad + " Soyadınız: " + musteri.Soyad + " Tc kimlik numaranız: " + musteri.TcNo + " Kaydınız güncellendi.");
        }
    }
}
