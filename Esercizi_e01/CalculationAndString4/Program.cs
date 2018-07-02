using System;

namespace CalculationAndString4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Leggere due numeri da Console, e stamparne la somma in modo "decorato", 
            //circondando la stampa del risultato con una cornice di qualche tipo.Ad esempio:
            //=====================
            //== la somma è: 45! ==
            //=====================


            const int numberFixedChars = 19;
            const char charToPrint = '*';
            bool continua = true;

            Console.WriteLine("STAMPA SOMMA ARTISTICA");

            while (continua)
            {
                

                
                bool inputOK1 = false;
                bool inputOK2;
                string stringaInput;


                int numInput1 = 0;
                do
                {
                    Console.Write("Inserire il primo numero intero da sommare\n(INVIO per chiudere il programma): ");
                    stringaInput = Console.ReadLine();
                    if (stringaInput == "")
                    {
                        continua = false;
                        inputOK2 = false;
                        break;
                    }
                    else
                    {
                        inputOK1 = int.TryParse(stringaInput, out numInput1);
                        inputOK2 = true;
                    }
                        
                }
                while (!inputOK1);

                int numInput2 = 0;
                while (inputOK2)
                {
                    Console.Write("Inserire il secondo numero intero da sommare\n(INVIO per chiudere il programma): ");
                    stringaInput = Console.ReadLine();
                    if (stringaInput == "")
                    {
                        continua = false;
                        break;
                    }
                    else
                    {
                        inputOK2 = int.TryParse(stringaInput, out numInput2);
                    }

                    if (inputOK2)
                    {
                        
                        int somma = numInput1 + numInput2;
                        int lengthNumber = somma.ToString().Length;
                        int lunghezzaRiga = numberFixedChars + lengthNumber;

                        Console.WriteLine(String.Empty.PadRight(lunghezzaRiga, '*'));
                        Console.WriteLine($"{charToPrint}  la somma è: {somma}!  {charToPrint}");
                        Console.WriteLine(String.Empty.PadRight(lunghezzaRiga, '*'));
                        break;
                    }
                    else
                        inputOK2 = true;
                }

                
                //Console.ReadLine();

            }
            
        }
    }
}
