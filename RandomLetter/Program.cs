using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi:");
            string name = Console.ReadLine();

            int counter = 0;
            
            foreach (char character in name)
            {
                counter++;
            }
            Console.WriteLine($"nimi {name} on {counter} sümbolit pikk.");
        }
    }
}
