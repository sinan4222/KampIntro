using System;

namespace Metotlar
{
    class Program
     {
        static void Main(string[] args)
        {


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Armut";
            urun2.Fiyati = 13;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            // type-safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------------------------");
            }



            Console.WriteLine("----------------- METOTLAR ---------------------------");

            //instance - class örneği oluşturmak
            // encapsulation - 
            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("----------- BU HATALI KULLANIM  ----");


            sepetManager.Ekle2("Armut", "Elazığ Armutu", 12,5);
            sepetManager.Ekle2("Elma", "Yeşil Elma ", 12,5);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu",22,5);

          
        }
    }
}


// Dont repeat yourself DRY - kendini tekrar etme Clean Code - Best Practice 