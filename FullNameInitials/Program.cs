using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi:");
            string LastName = Console.ReadLine();

            Console.WriteLine($"Tere {FirstName.ToUpper()[0]}. {LastName.ToUpper()[0]}.!");
        }
    }
}
