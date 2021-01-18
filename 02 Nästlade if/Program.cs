using System;

namespace _02_Nästlade_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange tal nummer 1: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Ange tal nummer 2: ");
            int second = int.Parse(Console.ReadLine());

            if (first == second)
            {
                Console.WriteLine("Talen {0} och {1} är lika", first, second);
            }
            else
            {
                if (first > second)
                {
                    Console.WriteLine("Det första talet, {0} är större än {1}", first, second);
                }
                else
                {
                    Console.WriteLine("Det andra talet, {1} är större än {0}", first, second);
                }
            }

            Console.Write("Ange en bokstav: ");
            int ch = Console.Read();

            if (ch == 'A' || ch == 'a')
            {
                Console.WriteLine("Vokal [ei]");
            }
            else if (char.ToUpper((char)ch) == 'E')
            {
                Console.WriteLine("Vokal [i:]");
            }
            //else if (ch == 'i')
            //{

            //}
            
            else
            {
                Console.WriteLine("Något annat (konsonant, siffra ell nå't)");
            }


            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
        }
    }
}
