using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskScheduler
{
    class Task
    {
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }

        public Task(string name, DateTime dueDate)
        {
            Name = name;
            DueDate = dueDate;
            Completed = false;
        }
    }

    class Program
    {
        static List<Task> tasks = new List<Task>();

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Task Scheduler");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Mark Task as Completed");
                Console.WriteLine("4. Exit");

                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTasks();
                        break;
                    case "3":
                        MarkTaskCompleted();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.Write("Enter task name: ");
            string name = Console.ReadLine();

            Console.Write("Enter due date (yyyy-MM-dd HH:mm): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dueDate))
            {
                Task newTask = new Task(name, dueDate);
                tasks.Add(newTask);
                Console.WriteLine("Task added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid date format. Task not added.");
            }
        }

        static void ViewTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks added yet.");
                return;
            }

            Console.WriteLine("Upcoming Tasks:");
            foreach (var task in tasks.OrderBy(t => t.DueDate))
            {
                Console.WriteLine($"- {task.Name} (Due: {task.DueDate.ToString("yyyy-MM-dd HH:mm")}) {(task.Completed ? "[Completed]" : "")}");
            }
        }

        static void MarkTaskCompleted()
        {
            ViewTasks();
            Console.Write("Enter task number to mark as completed: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber >= 1 && taskNumber <= tasks.Count)
            {
                tasks[taskNumber - 1].Completed = true;
                Console.WriteLine("Task marked as completed.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
    }
}
