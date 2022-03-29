using System;
using System.Collections.Generic;

namespace MyListOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myList1 = new List<int>();
            var myList2 = new List<float>();

            while (true)
            {
                Console.Write("Skriv et heltall: ");
                var nStr = Console.ReadLine();
                var n = Convert.ToInt32(nStr);
                myList1.Add(n);

                Console.Write("Skriv et desimaltall: ");
                var fStr = Console.ReadLine();
                var f = Convert.ToSingle(fStr);
                myList2.Add(f);

                //myList1.Show();
                //myList2.Show();
            }

            //var myList1 = new MyGenericList<int>();
            //var myList2 = new MyGenericList<float>();

            //while (true)
            //{
            //    Console.Write("Skriv et heltall: ");
            //    var nStr = Console.ReadLine();
            //    var n = Convert.ToInt32(nStr);
            //    myList1.Add(n);

            //    Console.Write("Skriv et desimaltall: ");
            //    var fStr = Console.ReadLine();
            //    var f = Convert.ToSingle(fStr);
            //    myList2.Add(f);

            //    myList1.Show();
            //    myList2.Show();
            //}


            //var myList = new MyList();

            //while (true)
            //{
            //    Console.Write("Skriv et ord: ");
            //    var word = Console.ReadLine();
            //    myList.Add(word);
            //    myList.Show();
            //}
        }
    }
}
