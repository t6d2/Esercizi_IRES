using System;

namespace CalculationAndString2
{
    class Program
    {
        static void Main(string[] args)
        {
            // stampa un numero dato, il suo doppio e il suo triplo

            double num = 54;
            double numDouble = num * num;
            double numTriple = Math.Pow(num, 3);

            Console.WriteLine($"il numero prescelto è {num}");
            Console.WriteLine($"il suo doppio è {numDouble}"); 
            Console.WriteLine($"il suo triplo è {numTriple}");
            Console.Read();
        }
    }
}
