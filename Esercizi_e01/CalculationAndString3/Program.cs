using System;

namespace CalculationAndString3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leggere tre stringhe da Console, 
            //e stampare la loro concatenazione sia in ordine diretto che in ordine inverso.

            Console.WriteLine("CONCATENAZIONE DI 3 STRINGHE");
            Console.Write("Inserire la prima stringa: ");
            string stringaInput1 = Console.ReadLine();
            Console.Write("Inserire la seconda stringa: ");
            string stringaInput2 = Console.ReadLine();
            Console.Write("Inserire la terza stringa: ");
            string stringaInput3 = Console.ReadLine();


            Console.WriteLine($"La stringa completa ordinata è {stringaInput1} {stringaInput2} {stringaInput3}");
            Console.WriteLine($"La stringa completa inversa è {stringaInput3} {stringaInput2} {stringaInput1}");
            Console.ReadLine();

        }
    }
}
