﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating
            Account client = new Account();

            Checking checking = new Checking(2000);
            checking.AccountNumb();

            Savings savings = new Savings(20000);
            savings.AccountNumb();


            string checkingaccount = ("Account Number: " + checking.AcctNumber);

            string savingsaccount = ("Account Number: " + savings.AcctNumber);
            string clientinfo = (client.ClientInfo());
            string checkingaccounttype = (checking.AccountType);

            string savingsaccounttype = (savings.AccountType);

            bool test = false;

            // menu is a do-while loop with a nested switch statement.

            do
            {

                Console.WriteLine("Hit Enter to Display Banking Menu");
                Console.ReadLine();

                client.DisplayMenu();
                string userchoice = Console.ReadLine();

                switch (userchoice.ToUpper())
                {
                    // Client Info
                    case "1":
                        Console.Clear();
                        Console.WriteLine(clientinfo);
                        break;
                    // Checking Account Balance
                    case "2A":
                        Console.Clear();
                        checking.Balance();
                        Console.WriteLine("Checking Account Balance: $" + checking.DepositBalance(checking.Deposit));
                        break;

                    // Savings Account Balance
                    case "2B":
                        Console.Clear();
                        savings.Balance();
                        Console.WriteLine("Savings Account Balance: $" + savings.DepositBalance(savings.Deposit));
                        break;

                    // Account Deposit
                    case "3A":
                        Console.Clear();
                        Console.WriteLine("How much would you like to deposit?");
                        checking.Deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine("You deposited: $" + checking.Deposit);
                        Console.WriteLine("Updated balance: $" + checking.DepositBalance(checking.Deposit));
                        break;

                    // Account Deposit
                    case "3B":
                        Console.Clear();
                        Console.WriteLine("How much would you like to deposit?");
                        savings.Deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine("You deposited: $" + savings.Deposit);
                        Console.WriteLine("Updated balance: $" + savings.DepositBalance(savings.Deposit));
                        break;

                    // Account Withdrawal
                    case "4A":
                        Console.Clear();
                        Console.WriteLine("How much would you like to withdraw?");
                        checking.Withdrawal = double.Parse(Console.ReadLine());
                        Console.WriteLine("You withdrew: $" + checking.Withdrawal);
                        Console.WriteLine("Updated balance: $" + checking.WithBalance(checking.Withdrawal));
                        break;

                    // Account Withdrawal

                   /* case "4Bb":
                        Console.Clear();
                        if
                            (savings.WithBalance(savings.Withdrawal) < savings.MinBalance)
                            Console.WriteLine("You exceeded your savings withdraw limit.");
                        savings.Deposit += savings.Withdrawal;
                        goto case "4B";

                    */
                    case "4B":
                        Console.Clear();
                        Console.WriteLine("How much would you like to withdraw?");
                        savings.Withdrawal = double.Parse(Console.ReadLine());
                        Console.WriteLine("You withdrew: $" + savings.Withdrawal);
                        Console.WriteLine("Updated balance: $" + savings.WithBalance(savings.Withdrawal));
                        break;

                   
                        

                    //Exit Banking
                    case "5":
                        Console.Clear();
                        Console.WriteLine("You have chosen to exit. Thanks and come again!");
                        Environment.Exit(0);
                        break;

                    //breaks the loop
                    default:
                        Console.Clear();
                        test = false;
                        break;
                }



            } while (!test);
        }
    }
}
