using System;

namespace _01_If_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkna ut det största av två tal:");
            Console.Write("Ange tal nummer 1: ");
            int smallerNumber = int.Parse(Console.ReadLine());
            Console.Write("Ange tal nummer 2: ");
            int biggerNumber = int.Parse(Console.ReadLine());

            if (smallerNumber > biggerNumber)
            {
                // Byt plats på smallerNumber och biggerNumber. 
                // Man måste gå via en mellanlagring
                int temp = biggerNumber;
                biggerNumber = smallerNumber;
                smallerNumber = temp;
            }

            Console.WriteLine("Det största talet är {0}", biggerNumber);
            Console.WriteLine("Det minsta talet är {0}", smallerNumber);

            Console.Write("Ange ett tal: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Talet {0} är jämnt", number);
            }
            else
            {
                Console.WriteLine("Talet {0} är udda", number);
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
        }
    }
}
