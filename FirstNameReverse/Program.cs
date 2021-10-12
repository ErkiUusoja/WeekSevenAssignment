using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string name = Console.ReadLine();                   
            
            if (name.Length >= 5)
            {
                for (int i = name.Length -1; i >= 0; i--)
                {
                    Console.WriteLine($"{name[i]}");
                }
            }
            else
            {
                Console.WriteLine($"{name}");
            }
        }
    }
}
