using System;

namespace CalculationAndString5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DATI ANAGRAFICI");

            string name;
            string surname;
            string city;

            Console.Write("Inserisci il nome: ");
            name = Console.ReadLine();
            Console.Write("Inserisci il cognome: ");
            surname = Console.ReadLine();
            Console.Write("Inserisci la città: ");
            city = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Nome   :\t");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(name);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Cognome:\t");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(name);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"Città  :\t");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(name);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("FINE DATI");
            Console.Read();
        }
    }
}
