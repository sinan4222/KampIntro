using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            // Collections Koleksiyonlarda 

            List<string> isimler2 = new List<string>() ;
            isimler2.Add("Engin");

            // Yukarıdaki gibi de ekleyebiliriz aşağıdaki gibi de
            List<string> isimler3 = new List<string>(){"Engin","Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler3[0]);
            Console.WriteLine(isimler3[1]);
            Console.WriteLine(isimler3[2]);
            Console.WriteLine(isimler3[3]);
            isimler3.Add("Sinan");
            Console.WriteLine(isimler3[4]);
            Console.WriteLine(isimler3[0]);
            
        }
    }
}
