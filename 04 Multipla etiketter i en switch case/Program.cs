using System;

namespace _04_Multipla_etiketter_i_en_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange ett djur (dog, crocodile, tortoise, snake, cat) ");
            string animal = Console.ReadLine();

            switch (animal)
            {
                case "dog":
                case "cat":
                    {
                        Console.WriteLine("MAMMAL");
                        break;
                    }
                case "crocodile":
                case "tortoise":
                case "snake":
                    {
                        Console.WriteLine("REPTILE");
                        break;
                    }
                default:
                    Console.WriteLine("Something else");
                    break;
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
        }
    }
}
