using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Hatice";
            musteri1.Soyad = "Koçak";
            musteri1.TcNo = "12345678910";
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Zehra";
            musteri2.Soyad = "Koçak";
            musteri2.TcNo = "12345695263";
            musteri2.Id = 2;

            Musteri musteri3= new Musteri();
            musteri3.Ad = "Fatma";
            musteri3.Soyad = "Yıldız";
            musteri3.TcNo = "1236541231223";
            musteri3.Id = 3;

            MusteriMenager musteriMenager = new MusteriMenager();
            musteriMenager.MusteriEkleme(musteri1);
            musteriMenager.MusteriEkleme(musteri2);
            musteriMenager.MusteriEkleme(musteri3);
            musteriMenager.MusteriSilme(musteri1);
            musteriMenager.MusteriSilme(musteri2);
            musteriMenager.MusteriSilme(musteri3);
            musteriMenager.MusteriBilgileriGuncelleme(musteri1);
            musteriMenager.MusteriBilgileriGuncelleme(musteri2);
            musteriMenager.MusteriBilgileriGuncelleme(musteri3);




        }
    }
}
