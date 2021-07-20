using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {

        //encapsulation tamamını içeren 
        public void Add(Product product) // Product türünde bir değer ver demek istiyoruz () içinde
        {
            Console.WriteLine(product.ProductName + "  Eklendi !");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "  Güncellendi !");
        }















        //Void ne işe yarar ; void ile belirtilen metotlarda emir kipi ile çağırıyoruz işlem yaptırıyoruz.

        /* Aşağıdaki metotların arasındaki farklara değinecek olursak 
           
        void'deki toplama işlemini yapıtırıp yazdırıyor. Daha sonra o işlem sonucunu kullanmak istediğimizde ise kullanamıyoruz
        aşağıdaki void örneğine baktığımızda toplama işlemini yaptırıyoruz fakat sonucu başka yerde 2 ile çarpmamız mümkün olmuyor.
        o yüzden returnleri kullanıyoruz
         
        

        public int Topla(int sayi1 , int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
        } */
    }
}
