using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            while (true)
            {
                Console.WriteLine("\nEmployee Management System");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Remove Employee");
                Console.WriteLine("3. Display Employees");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddEmployee(employees);
                        break;
                    case "2":
                        RemoveEmployee(employees);
                        break;
                    case "3":
                        DisplayEmployees(employees);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddEmployee(List<Employee> employees)
        {

            Console.Write("Enter Employee Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Position: ");
            string position = Console.ReadLine();

            Employee employee = new Employee
            {
                Id = id,
                Name = name,
                Age = age,
                Position = position
            };

            employees.Add(employee);
            Console.WriteLine("Employee added successfully!");
        }

        static void RemoveEmployee(List<Employee> employees)
        {
            Console.Write("Enter Employee Id to remove: ");
            string id = Console.ReadLine();

            Employee employeeToRemove = employees.Find(e => e.Id.ToString() == id);

            if (employeeToRemove != null)
            {
                employees.Remove(employeeToRemove);
                Console.WriteLine("Employee removed successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        static void DisplayEmployees(List<Employee> employees)
        {
            Console.WriteLine("\nList of Employees:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Age: {employee.Age}, Position: {employee.Position}");
            }
        }
    }

   
}
