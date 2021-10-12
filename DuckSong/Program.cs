using System;

namespace DuckSong
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine($"{i} little ducks went swimming one day over the hill and far away mother duck said, Quack quack quack quack but only {i - 1} little ducks came back!");
                if (i <= 1)
                {
                    Console.WriteLine("sad mother duck went out one day over the hill and far away the sad mother duck said, Quack quack quack quack and all of the 5 little ducks came back!");
                }
            }
        }
    }
}
