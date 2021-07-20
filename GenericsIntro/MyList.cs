using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //MyList ' imde T ile çalışacağım ne anlama geliyor ? T vermemizin sebebi kullanıcı ister string ister int değer girsin
    // kısacası saça göre tarak vurmak diyebiliriz .
    class MyList<T>
    {

        T[] items ;
        //ctor  -> constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }



        }
    }
}
