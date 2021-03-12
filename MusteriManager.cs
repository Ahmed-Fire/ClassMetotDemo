using System;
namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + " " + "kişisi eklendi");
        }

        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.MusteriAd + " " + musteri.MusteriSoyad);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + " " + "kişisi silindi");
        }
    }
}
