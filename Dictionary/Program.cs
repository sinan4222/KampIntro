using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hazır Dictionary
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(181, "Sinan Bağlantı");
            Console.WriteLine(ogrenci.Count);


            //Kendi Yaptığımız Dictionary
            MyDictionary<int, string> ogrenci2 = new MyDictionary<int, string>();
            ogrenci2.Add(317, "Selim Bağlantı");
            ogrenci2.Add(317, "Selim Bağlantı");
            ogrenci2.Add(317, "Selim Bağlantı");
            ogrenci2.Add(317, "Selim Bağlantı");
            ogrenci2.Add(317, "Selim Bağlantı");
            Console.WriteLine(ogrenci2.Count);
          
        }



        class MyDictionary<T, K> 
        {
            T[] _arrayT;
            K[] _arrayK;
            T[] _tempArrayT;
            K[] _tempArrayK;

            public MyDictionary()
            {
                _arrayT=new T[0];
             _arrayK= new K[0];
            }
            public void Add(T item, K value)
            {
                _tempArrayK = _arrayK;
                _tempArrayT = _arrayT;

                _arrayT = new T[_arrayT.Length+1];
                _arrayK = new K[_arrayK.Length+1];

                for (int i = 0; i < _tempArrayK.Length; i++)
                {
                    _arrayK[i] = _tempArrayK[i];
                    _arrayT[i] = _tempArrayT[i];
                }
                _arrayK[_arrayK.Length - 1]=value;
                _arrayT[_arrayT.Length - 1]=item;


                for (int i = 0; i < _tempArrayK.Length; i++)
                {
                    Console.WriteLine(_arrayK[i]);
                    Console.WriteLine(_arrayT[i]);
                }
            }

        

            public int Count
            {
                get { return _arrayK.Length; }
           
            }


        }
    }
}
