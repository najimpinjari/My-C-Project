using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace File_Reader
{
    class Program
    {
        static void Main()
        {
            List<Student> studentDatabase = new List<Student>();

            while (true)
            {
                Console.WriteLine("Student Database Menu:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display Students");
                Console.WriteLine("3. Search Student by Name");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter student age: ");
                        int age = int.Parse(Console.ReadLine());
                        studentDatabase.Add(new Student(name, age));
                        break;

                    case 2:
                        Console.WriteLine("List of Students:");
                        foreach (var student in studentDatabase)
                        {
                            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
                        }
                        break;

                    case 3:
                        Console.Write("Enter student name to search: ");
                        string searchName = Console.ReadLine();
                        Student foundStudent = studentDatabase.Find(student => student.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
                        if (foundStudent != null)
                        {
                            Console.WriteLine($"Student found - Name: {foundStudent.Name}, Age: {foundStudent.Age}");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}