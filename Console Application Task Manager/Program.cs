using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application_Task_Manager
{
    class Program
    {
        static void Main()
        {   
            List<string> tasks = new List<string>();

            while(true)
            {
                Console.WriteLine("task Manager");
                Console.WriteLine("1.Add Task");
                Console.WriteLine("2 view tasks");
                Console.WriteLine("3. Exit");

                Console.WriteLine("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a new task :  ");
                        string newTask = Console.ReadLine();
                        tasks.Add(newTask);
                        Console.WriteLine("Task added successfully ! :");
                        break;

                    case 2:
                        Console.WriteLine("Task : ");
                        foreach (string task in tasks)
                        {
                            Console.WriteLine($" _ {task}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter task manager.Goodby !"); 
                        Environment.Exit(0);
                    break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again. ");
                    break;
                }
            }            
        }
    }
}
