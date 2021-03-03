using System;

namespace Hola_Mundo
{
    class Program
    {
        static void Main(string[] args)
        {
                        Console.WriteLine("Hola Mundo");
             Console.WriteLine("Cual es tu nombre:");
             var name = Console.ReadLine();
             var date = DateTime.Now;
             Console.WriteLine($"\nHola, {name}, on {date:d} at {date:t}!");
             Console.Write("\nPress any key to exit...");
             Console.ReadKey(true);

        }
    }
}
