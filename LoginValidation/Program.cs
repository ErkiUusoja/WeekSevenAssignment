using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string password;
            Console.WriteLine("login");
            login = Console.ReadLine();
            Console.WriteLine("password");
            password = Console.ReadLine();
            Console.WriteLine("PIN-kood");
            string PINcode = Console.ReadLine();

            int counter = 0;

            foreach (char character in PINcode)
            {
                counter++;
                if (PINcode.Length < 4)
                {
                    Console.WriteLine("vale PIN. proovi uuesti.");
                    break;
                }
            }
            if ((login == "admin") && (password == "pass1234") && (PINcode == "1234"))
            {
                Console.WriteLine("Tere tulemast!");
            }
            else if ((login != "admin") && (password == "pass1234"))
            {
                Console.WriteLine("midagi läks valesti. proovi uuesti.");
            }
            else if ((login == "admin") && (password != "pass1234"))
            {
                Console.WriteLine("midagi läks valesti. proovi uuesti.");
            }
        }
    }
}
