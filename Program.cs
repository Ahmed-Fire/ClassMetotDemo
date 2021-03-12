using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAd = "Ahmed";
            musteri1.MusteriSoyad = "Imad";
            musteri1.yas = 27;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAd = "Ali";
            musteri2.MusteriSoyad = "Yimlaz";
            musteri2.yas = 25;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            Console.WriteLine("-------------------------");
            Console.WriteLine("Müşteri Listesi");

            foreach (var musteri in musteriler)
            {
                musteriManager.Listeleme(musteri);
            }
            Console.WriteLine("-------------------------");
            musteriManager.Silme(musteri2);
        }
    }

}