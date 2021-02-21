using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> sehirler = new Dictionary<int, string>();

            sehirler.Add(52, "Ordu");
            sehirler.Add(34, "Istanbul");

            Console.WriteLine(sehirler.Count);


        }
    }
}
