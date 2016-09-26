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
            int subSelect;
            string userName ="George";
            int accountNum = 987123;
            
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
                        Console.Clear();
                        Console.WriteLine("\nClient Information\n");
                        Console.WriteLine("UserName: {0}\nAccount Number: {1}", userName, accountNum);
                        Console.Write("\nPress any key continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        // View account balance - sub menu Chk, Res, and Sav
                        Console.WriteLine("\n2 - View account information - Selected\n");
                        subSelect = SubMenu();
                        if (subSelect == 1)
                        {
                            // Create new Checking object
                            Console.WriteLine("subSelect: {0} - Checking", subSelect);
                            CheckingAccount checking = new CheckingAccount();

                            
                        }
                        else if(subSelect == 2)
                        {
                            //Create new Reserve Object
                            Console.WriteLine("subSelect: {0} - Reserve", subSelect);
                        }
                        else if (subSelect == 3)
                        {
                            // Create new Savings object
                            Console.WriteLine("subSelect: {0} - Savings", subSelect);
                        }
                        else
                        {
                            // back to main
                            Console.WriteLine("subSelect: {0} - Back to main", subSelect);
                        }
                        Console.WriteLine();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        // Make a deposit
                        Console.WriteLine("\n3 - Make a deposit - Selected\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        // Make a withdrawal
                        Console.WriteLine("\n4 - Make a cash withdrawal - Selected\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        // Quit program
                        Console.WriteLine("\n5 - Quit - Selected\n");
                        Console.WriteLine("Goodbye!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        // if another number is selected
                        Console.WriteLine("Please select a number between (1-5)\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (menuOption != 5);
        }
        static int SubMenu()
        {
            // Initialize sub-menu variable
            int subMenuOption;
            int subSelection = 0;

            // Display sub-menu
            do
            {
                Console.Clear();
                Console.WriteLine("View Account Balance\n");
                Console.WriteLine("Please select an account to view\n");
                Console.WriteLine("1 - Checking Account");
                Console.WriteLine("2 - Reserve Account");
                Console.WriteLine("3 - Savings Account");
                Console.WriteLine("4 - Return to main menu");
               
                Console.Write("\nMenu selection: ");
                subMenuOption = int.Parse(Console.ReadLine());

                // Sub-menu switch
                switch (subMenuOption)
                {
                    case 1:
                        // Checking account balance
                        Console.WriteLine("\n1 - Checking Account\n");
                        subSelection = subMenuOption;
                        Console.Clear();
                        break;
                    case 2:
                        // Reserve account balance
                        Console.WriteLine("\n2 - Reserve Account\n");
                        subSelection = subMenuOption;
                        Console.Clear();
                        break;
                    case 3:
                        // Savings account balance
                        Console.WriteLine("\n3 - Savings Account\n");
                        subSelection = subMenuOption;
                        Console.Clear();
                        break;
                    case 4:
                        // Return to main menu
                        Console.WriteLine("\n4 - Return to main menu\n");
                        subSelection = 0;
                        Console.Clear();
                        break;
                    default:
                        // if another number is selected
                        Console.WriteLine("Please select a number between (1-4)\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;                   
                }
                return subSelection;
            } while (subMenuOption != 4);
        }
    }
}
