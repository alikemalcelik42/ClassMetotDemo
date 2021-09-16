using System;

namespace ClassMetotDemo
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.FirstName} added");
        }

        public void Remove(Customer customer)
        {
            Console.WriteLine($"{customer.FirstName} removed");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine($"{customer.FirstName} updated");
        }

        public void GetCustomers()
        {
            Console.WriteLine("Customers listed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new Customer() { Id = 1, FirstName = "Ali", LastName = "Demir", PhoneNumber = "05616626956" });
            customerManager.Update(new Customer() { Id = 1, FirstName = "Ali", LastName = "Ateş", PhoneNumber = "05616626956" });
            customerManager.Remove(new Customer() { Id = 1, FirstName = "Ali", LastName = "Ateş", PhoneNumber = "05616626956" });
            customerManager.GetCustomers();
        }
    }
}
