using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();


            myDictionary.Add(1, "Adana");
            myDictionary.Add(1, "Adana");
            myDictionary.Add(34, "İstanbul");
            myDictionary.Add(35, "İzmir");
            myDictionary.Add(35, "İzmir");
            myDictionary.Add(35, "İzmir");
            myDictionary.Add(35, "İzmir");
            myDictionary.Getir();
           

            Console.ReadLine();


        }
    }
}
