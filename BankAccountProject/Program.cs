using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables
            int menuOption;

            // Display Menu

            do
            {
                Console.WriteLine("Welcome to Terminal Tower Bank.\n");
                Console.WriteLine("Please select from one of the menu selections below.\n");

                Console.WriteLine("1 - Client Information");
                Console.WriteLine("2 - View account balance");
                Console.WriteLine("3 - Make a deposit");
                Console.WriteLine("4 - Make a cash withdrawal");
                Console.WriteLine("5 - Quit");

                Console.Write("\nMenu selection: ");
                menuOption = int.Parse(Console.ReadLine());

                // Menu switch
                switch (menuOption)
                {
                    case 1:
                        // View client information Name and account number hardcoded
                        Console.WriteLine("\n1 - Client Information - Selected\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        // View account balance - sub menu Chk, Res, and Sav
                        Console.WriteLine("\n2 - View account balance\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        // Make a deposit
                        Console.WriteLine("\n3 - Make a deposit\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        // Make a withdrawal
                        Console.WriteLine("\n4 - Make a cash withdrawal\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        // Quit program
                        Console.WriteLine("\n5 - Quit\n");
                        Console.WriteLine("Goodbye!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        // if another number is selected
                        Console.WriteLine("Please select a number between (1-4)\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (menuOption != 5);
            
        }
    }
}
