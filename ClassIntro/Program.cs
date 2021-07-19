using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Sinan";
            int yas = 22;

            // Classlar aşağıdaki gibi kullanılır
            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Furkan Demiroğ";
            kurs2.IzlenmeOrani = 48;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmen = "Serkan Demiroğ";
            kurs3.IzlenmeOrani = 23;



            //   Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);


            Kurs[] kurslar = new Kurs[]
            {
                kurs1,kurs2,kurs3
            };

            foreach (Kurs kurs in kurslar)
            {
                Console.Write(kurs.KursAdi);
                Console.Write(kurs.Egitmen);
                Console.WriteLine(kurs.IzlenmeOrani);
            }

        }
    }

    // Sanki kendi veri tipimizi yazıyormuş gibi düşünebiliriz
    // Classımızı aşağıdaki şekilde oluşturuyoruz
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }

}
