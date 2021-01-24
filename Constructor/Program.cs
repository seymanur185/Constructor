using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(); 
        }
    }
    class Customer
    {
        //default Constructor
        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştı");

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string City { get; set; }
    }
}
