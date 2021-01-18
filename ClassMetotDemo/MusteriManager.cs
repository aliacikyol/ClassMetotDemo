using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.AdSoyad + " isimli " + musteri.Iban + " İban numaralı müşteri bankacılık sistemine eklenmiştir ");


        }
        public void Sil(Musteri musteri)
        {

            Console.WriteLine(musteri.AdSoyad + " isimli " + musteri.Iban + " İban numaralı müşteri bankacılık sisteminden silinmiştir. ");

        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.AdSoyad + " - " + musteri.Iban);
        }
    }
}
