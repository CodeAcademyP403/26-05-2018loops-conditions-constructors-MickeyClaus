using System;

namespace Pro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string input;

            Help hp = new Help();

            do
            {
                Console.WriteLine("Please, select action.");
                Console.WriteLine("1. Help");
                Console.WriteLine("2. Exit");
                Console.Write(">>> ");

                input = Console.ReadLine();
                if (checkInput(input))
                {
                    int inputNumber = Convert.ToInt32(input);
                    switch (inputNumber)
                    {
                        case 1:
                            hp.UHelp();
                            break;
                        case 2:
                            Console.WriteLine("Thank You very much.");
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("\n--------------***--------------");
                            Console.WriteLine("You should select only valid actions");
                            Console.WriteLine("--------------***--------------\n");
                            Console.WriteLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\n--------------***--------------");
                    Console.WriteLine("Please, select only valid numbers.");
                    Console.WriteLine("--------------***--------------\n");
                }

            } while (input != "2");
            
        }

        private static bool checkInput(string input)
        {
            try
            {
                Convert.ToInt32(input);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
