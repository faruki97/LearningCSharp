using System;
using Day3_Work3;

class Program
{
    public static void Main(string[] args)
    {
        Customer customer1 = new Customer();
        Customer customer2 = new Customer();
        Customer customer3 = new Customer();
        Customer customer4 = new Customer();


        customer1.CustomerCity = " Bursa";
        customer1.CustomerId = 1;
        customer1.CustomerName = " Faruk ";
        customer1.CustomerSurname = " Farazi";

        customer2.CustomerCity = " İstanbul";
        customer2.CustomerId = 2;
        customer2.CustomerName = " Mehmet ";
        customer2.CustomerSurname = " Bilemem";

        customer3.CustomerCity = " Balıkesir ";
        customer3.CustomerId = 3;
        customer3.CustomerName = " Ahmet ";
        customer3.CustomerSurname = " Bilemezsin";

        customer4.CustomerCity = " Ankara";
        customer4.CustomerId = 4;
        customer4.CustomerName = " Hasan ";
        customer4.CustomerSurname = " Bilemezler";

        Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

        foreach (var customer in customers)
        {
            Console.WriteLine(customer.CustomerName);

        }

        CustomerManager customerManager = new CustomerManager();

        customerManager.customerAdd(customer1);
        customerManager.customerDelete(customer2);
        customerManager.customerUptade(customer3);




        

   }



}