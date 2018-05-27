using System;
using System.Collections.Generic;
using System.Text;

namespace Pro
{
    class Help
    {
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

        public void UHelp()
        {
            string input;
            
            do
            {
                Console.WriteLine("Please, select action.");
                Console.WriteLine("1. dir - Environment.CurrentDirectory");
                Console.WriteLine("2. disks - Environment.GetLogicalDrives");
                Console.WriteLine("3. is64bitop - Environment.Is64BitOperatingSystem");
                Console.WriteLine("4. is64proc - Environment.Is64BitProcess");
                Console.WriteLine("5. macname - Environment.MachineName");
                Console.WriteLine("6. osdetail - Environment.OSVersion");
                Console.WriteLine("7. osplatform - Environment.OSVersion.Platform");
                Console.WriteLine("8. osversion - Environment.OSVersion.Version");
                Console.WriteLine("9. domname - Environment.UserDomainName");
                Console.WriteLine("10. username - Environment.UserName");
                Console.WriteLine("11. osdir - Environment.SystemDirectory");
                Console.WriteLine("12. Exit");
                Console.Write(">>> ");

                input = Console.ReadLine();
                if (checkInput(input))
                {
                    int inputNumber = Convert.ToInt32(input);
                    switch (inputNumber)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("Your Current directory is big/Debug");
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("Your Logical Drive is Physical");
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine();
                            Console.WriteLine("Your Operating System is 64x");
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.WriteLine();
                            Console.WriteLine("Your Current directory is ");
                            Console.WriteLine();
                            break;
                        case 5:
                            Console.WriteLine();
                            Console.WriteLine("Your Machine name is Hp");
                            Console.WriteLine();
                            break;
                        case 6:
                            Console.WriteLine();
                            Console.WriteLine("Your Os Vercion is 64 ");
                            Console.WriteLine();
                            break;
                        case 7:
                            Console.WriteLine();
                            Console.WriteLine("Your Platform version is 32");
                            Console.WriteLine();
                            break;
                        case 8:
                            Console.WriteLine();
                            Console.WriteLine("Your OS Version is 64");
                            Console.WriteLine();
                            break;
                        case 9:
                            Console.WriteLine();
                            Console.WriteLine("Your Domain Name is Elnur ");
                            Console.WriteLine();
                            break;
                        case 10:
                            Console.WriteLine();
                            Console.WriteLine("Your Username is Elnur");
                            Console.WriteLine();
                            break;
                        case 11:
                            Console.WriteLine();
                            Console.WriteLine("Your System directory is Apple");
                            Console.WriteLine();
                            break;
                        case 12:
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

            } while (input != "12");
        }
    }
}
