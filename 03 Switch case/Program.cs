using System;

namespace _03_Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange ett tal: ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case <= 1:  // NYTT I C# VERSION 9! :-D
                    {
                        Console.WriteLine("Måndag");
                        break;
                    }
                case 2:
                case 3:
                    {
                        if (day == 2)
                        {
                            Console.WriteLine("Tisdag");
                        }
                        else
                        {
                            Console.WriteLine("Onsdag");
                        }
                        
                        break;
                    }
                //case 3:
                //    {
                //        Console.WriteLine("Onsdag");
                //        break;
                //    }
                case 4:
                    {
                        Console.WriteLine("Torsdag");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Fredag");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Lördag");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Söndag");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ange ett tal mellan 1 och 7!");
                        break;
                    }
            }

            

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
        }
    }
}
