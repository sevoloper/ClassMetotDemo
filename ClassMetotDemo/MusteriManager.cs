using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " eklendi");
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " silindi");
        }

        public void Listeleme(Musteri[] musteri)
        {
            Console.WriteLine("Müşteriler");

            foreach (var item in musteri)
            {
                Console.Write(item.Id + " ");
                Console.Write(item.Ad + " ");
                Console.Write(item.Soyad);
            }
            Console.WriteLine();
        }

    }
}
