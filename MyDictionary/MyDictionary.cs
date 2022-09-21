using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<Tkey, Tvalue>
    {

        Tkey[] key = new Tkey[0];
        Tvalue[] value = new Tvalue[0];
        public void Add(Tkey anahtar, Tvalue deger)
        {

            Tkey[] tempKeyArray = key;
            Tvalue[] tempValueArray = value;

            key = new Tkey[key.Length + 1];
            value = new Tvalue[value.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                if (tempKeyArray[i].Equals(anahtar))
                {
                    continue;
                }
                else
                {
                    key[i] = tempKeyArray[i];
                    value[i] = tempValueArray[i];
                }
            }
            key[key.Length - 1] = anahtar;
            value[value.Length - 1] = deger;
        }
        public void Getir()
        {
            for (int i = 0; i < key.Length; i++)
            {
                if (key[i].Equals(0))
                continue;  
                else
                Console.WriteLine($"key : {key[i]}, value : {value[i]}");
            }
        }






    }
}
