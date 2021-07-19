using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            // Do not repeat yourself - Kendini Tekrarlama
            // Değer tutucu , alias
            string kategoriEtiketi = "kategori";
            Console.WriteLine(kategoriEtiketi);

            //Değişken Türleri
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;



            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


            if (sistemeGirisYapmisMi==true) //Şart Doğru ise Süslü Parantez içindeki komut satırlarını Okur

            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else // Şart Doğru Değilse kod bloğu içindenki komutları okur
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


           
        }
    }
}
