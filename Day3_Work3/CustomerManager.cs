using System;
namespace Day3_Work3
{
    public class CustomerManager
    {
        public void customerAdd(Customer customer)
        {
            Console.WriteLine(customer.CustomerName+"Customer Added.");
            Console.WriteLine("--------------");
        }

        public void customerDelete (Customer customer)
        {
            Console.WriteLine(customer.CustomerName+"Customer Deleted.");
            Console.WriteLine("--------------");

        }

        public void customerUptade (Customer customer)
        {
            Console.WriteLine(customer.CustomerName+"Customer Uptaded.");
            Console.WriteLine("--------------");

        }
    }
}

