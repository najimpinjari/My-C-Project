using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        RoomOwner roomOwner = new RoomOwner();

        while (true)
        {
            Console.WriteLine("===== Room Owner Management System =====");
            Console.WriteLine("1. Add Tenant");
            Console.WriteLine("2. View Tenant Details");
            Console.WriteLine("3. Record Payment");
            Console.WriteLine("4. Display Payment History");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    roomOwner.AddTenant();
                    break;

                case "2":
                    roomOwner.ViewTenantDetails();
                    break;

                case "3":
                    roomOwner.RecordPayment();
                    break;

                case "4":
                    roomOwner.DisplayPaymentHistory();
                    break;

                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

class Tenant
{
    public string Name { get; set; }
    public double RentAmount { get; set; }
    public double TotalPayments { get; set; }
}

class RoomOwner
{
    private List<Tenant> tenants;

    public RoomOwner()
    {
        tenants = new List<Tenant>();
    }

    public void AddTenant()
    {
        Console.Write("Enter Tenant Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Rent Amount: ");
        double rentAmount = Convert.ToDouble(Console.ReadLine());

        Tenant newTenant = new Tenant
        {
            Name = name,
            RentAmount = rentAmount
        };

        tenants.Add(newTenant);
        Console.WriteLine($"Tenant '{name}' added successfully!");
    }

    public void ViewTenantDetails()
    {
        Console.WriteLine("===== Tenant Details =====");

        if (tenants.Count == 0)
        {
            Console.WriteLine("No tenants available.");
        }
        else
        {
            foreach (var tenant in tenants)
            {
                Console.WriteLine($"Tenant: {tenant.Name}\tRent Amount: {tenant.RentAmount:C}\tTotal Payments: {tenant.TotalPayments:C}");
            }
        }
    }

    public void RecordPayment()
    {
        Console.Write("Enter Tenant Name: ");
        string name = Console.ReadLine();

        Tenant tenant = tenants.Find(t => t.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (tenant != null)
        {
            Console.Write("Enter Payment Amount: ");
            double paymentAmount = Convert.ToDouble(Console.ReadLine());

            tenant.TotalPayments += paymentAmount;
            Console.WriteLine($"Payment recorded successfully for '{name}'.");
        }
        else
        {
            Console.WriteLine($"Tenant '{name}' not found.");
        }
    }

    public void DisplayPaymentHistory()
    {
        Console.WriteLine("===== Payment History =====");

        if (tenants.Count == 0)
        {
            Console.WriteLine("No tenants available.");
        }
        else
        {
            foreach (var tenant in tenants)
            {
                Console.WriteLine($"Tenant: {tenant.Name}\tTotal Payments: {tenant.TotalPayments:C}");
            }
        }
    }
}
