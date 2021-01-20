using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri
            {
                Id = 0,
                Ad = "Kaan",
                Soyad = "Epçeçen"
            };

            Musteri musteri2 = new Musteri
            {
                Id = 1,
                Ad = "Şevval",
                Soyad = "Ülkü"
            };

            Musteri musteri3 = new Musteri
            {
                Id = 2,
                Ad = "Ceren",
                Soyad = "Epçeçen"
            };

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri1);
            musteriManager.MusteriEkleme(musteri2);

            musteriManager.MusteriSilme(musteri3);

            

            musteriManager.Listeleme(musteriler);
        }
    }
}
