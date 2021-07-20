using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id=2,CategoryId=3,ProductName="Bilgisayar",UnitPrice=2222,UnitsInStock=10};

            //Case senitive küçük-büyük harf duyarlılığı var
            //PascalCase   camelCase birisinin ilk harfleri büyük diğerinin ilk kelimenin ilk harfi küçük         
            ProductManager productManager = new ProductManager();
            // Yukarıda ProductManager türündeki productManager yeni bir referans numarası almış ProductManager'dir. Sol taraf stack sağ taraf ise heap
            
            productManager.Add(product2);

        }
    }
}
