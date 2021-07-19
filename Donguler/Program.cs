using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java Kurs";

      /*  
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
      */

            //array - dizi

            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs",
                "Java Kurs"
            };
            





            // Sayaçımızı yani i'yi 0'dan başlatıp 1'er artaraj kurslar dizisinin uzunluğundan küçük olana kadar çalıştırır
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }

            Console.WriteLine("FOR BİTTİ");

            // dizi temelli yapıları tek tek dolaşmaya yarıyor
            // in kurslar dediğimizde kursları tek tek dolaş demek
            // kurs yerine abc xyz desekte çalışır.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


        }
    }
}
