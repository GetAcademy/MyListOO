using System;

namespace MyListOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Pause til 10:38
            */
            var myList = new MyList();

            while (true)
            {
                Console.Write("Skriv et ord: ");
                var word = Console.ReadLine();
                myList.Add(word);
                myList.Show();
            }
        }
    }
}
