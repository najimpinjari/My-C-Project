using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_TaskManager_Class
{
    class TaskManager
    {
        private List<Task> tasks = new List<Task>();

        public void AddTask(string description)
        {
            tasks.Add(new Task { Description = description, IsCompleted = false });
        }

        public void MarkTaskAsCompleted(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks[index].IsCompleted = true;
                Console.WriteLine("Task marked as completed: " + tasks[index].Description);
            }
            else
            {
                Console.WriteLine("Invalid task index");
            }
        }

        public void DisplayTasks()
        {
            Console.WriteLine("Task List:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. [{(tasks[i].IsCompleted ? "X" : " ")}] {tasks[i].Description}");
            }
        }
    }

}
