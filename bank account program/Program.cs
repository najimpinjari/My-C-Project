using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_account_program
{
    class BankAccount
    {    
        public string AccountHolder {  get; set; }
        public double Balance { get; private set; }

        public BankAccount(string accountHolder, double initialBalance)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if(amount > 0)
            {
                Balance += amount;
                Console.WriteLine($" Deposited {amount} . New balance : {Balance}");
            }
            else 
            {
                Console.WriteLine("invalid deposti amount. please enter a positive value");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance) 
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount}. new balance {Balance}");
            }
            else if (amount <=0)
            {
                Console.WriteLine("invalid withdrowal amount . please enter positive value");
            }
            else
            {
                Console.WriteLine("insufficient funds for withdrawal");
            }
        }
        public void CheckBalance()
        {
            Console.WriteLine($"Account balance for {AccountHolder} : {Balance}");
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("welcome to the bank account program !");

                Console.Write("enter your name ");
                string accountHolder = Console.ReadLine();

                Console.WriteLine("enter yout balance");
                if(double.TryParse(Console.ReadLine(), out double initialBalance ) && initialBalance >= 0)
                {
                    BankAccount account = new BankAccount(accountHolder, initialBalance);

                    while(true)
                    {
                        Console.WriteLine("\nOptions");
                        Console.WriteLine("1,Deposit");
                        Console.WriteLine("2.Withdraw");
                        Console.WriteLine("3.check Balance");
                        Console.WriteLine("4.Exit");
                        Console.WriteLine("Enter your choice: ");

                        if(int.TryParse(Console.ReadLine(), out int choice))
                        {
                            switch (choice)
                            {
                                case 1:
                                    Console.Write("Enter diposit amount");
                                    if (double.TryParse(Console.ReadLine(), out double depositAmount))
                                    {
                                        account.Deposit(depositAmount);
                                    }
                                    else
                                    {
                                        Console.WriteLine("invalid input , please enter a valid number ");
                                    }

                                break;
                                case 2:
                                    Console.Write("Enter withdrawal amount: ");
                                    if (double.TryParse(Console.ReadLine(),out depositAmount))
                                    {
                                        account.Deposit(depositAmount);
                                    }
                                    else
                                    {
                                        Console.WriteLine("invalid input , please enter a valid number ");
                                    }
                                break;
                                case 3:
                                    account.CheckBalance();
                                    break;
                                case 4:
                                    Console.WriteLine("Exiting the program . Goodbye !");
                                    Environment.Exit(0);
                                break;
                                    default:
                                    Console.WriteLine("Invalid choice. pleaes try again.");

                                    break;
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("invalid input . please enter a valid number");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("invalid input please enter a valid number");
                }
            }

        }
        
        
    }
}
