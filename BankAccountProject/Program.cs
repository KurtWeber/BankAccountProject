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

            // Instances of the objects
            Checking chkaccount = new Checking(userName, accountNum);
            Savings savaccount = new Savings(userName, accountNum);
            Reserve resaccount = new Reserve(userName, accountNum);
            
            // Display Menu
            do
            {
                Console.WriteLine("Welcome to Terminal Tower Bank.\n");
                Console.WriteLine("Please select from one of the menu selections below.\n");

                Console.WriteLine("1 - Client information");
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
                        Console.WriteLine("UserName: {0}\nAccount Number: {1}", chkaccount.UserName, chkaccount.AccountNum);
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
                            //chkaccount.Display();
                            chkaccount.CurrentBalance();
                        }
                        else if(subSelect == 2)
                        {
                            resaccount.CurrentBalance();
                        }
                        else if (subSelect == 3)
                        {
                            savaccount.CurrentBalance();
                        }
                        Console.WriteLine();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        // Make a deposit
                        Console.WriteLine("\n3 - Make a deposit - Selected\n");
                        subSelect = SubMenu();

                        Console.WriteLine();
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
                Console.WriteLine("Please select an account\n");
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
                        subSelection = subMenuOption;
                        break;
                    case 2:
                        // Reserve account balance
                        subSelection = subMenuOption;
                        break;
                    case 3:
                        // Savings account balance
                        subSelection = subMenuOption;
                        break;
                    case 4:
                        // Return to main menu
                        subSelection = 0;
                        break;
                    default:
                        // if another number is selected
                        Console.WriteLine("Please select a number between (1-4)");
                        Console.Clear();
                        break;                   
                }
                return subSelection;
            } while (subMenuOption != 4);
        }
    }
}
