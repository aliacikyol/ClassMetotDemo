using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.AdSoyad = "Sultan Çelebioğulları";
            musteri1.Iban = "TR340000154214000124578965";
            

            Musteri musteri2 = new Musteri();
            musteri2.AdSoyad = "Nemide Çelebioğulları";
            musteri2.Iban = "TR340000123456789456123045";

            Musteri musteri3 = new Musteri();
            musteri3.AdSoyad = "Mustafa Nuri Çelebioğulları";
            musteri3.Iban = "TR34000123456789654258369";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2,musteri3 };

            Console.WriteLine("ABC Bank Müşteri Takip Sistemi");
            Console.WriteLine("---------------------------------");

            foreach (Musteri musteri in musteriler)
            {
                
                Console.WriteLine(musteri.AdSoyad);
                
                Console.WriteLine(musteri.Iban);
                Console.WriteLine("------------------");

            }
            
            
            
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("--------------------");

            musteriManager.Sil(musteri2);

            Console.WriteLine("--------------------");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);





        }
    }
}
