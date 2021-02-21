using System;

namespace ClassMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "İsrafil";
            customer1.SurName = "Hallaç";
            

            Customer customer2 = new Customer();
            customer2.Name = "Sezgin";
            customer2.SurName = "Hallaç";

            Customer[] customers = new Customer[] { customer1, customer2 };
            foreach (var customer in customers)
            {
                Console.WriteLine("Müşterinin Adı: "+ customer.Name +"---------" + "Müşterinin SoyAdı: " + customer.SurName);
                
            }
            Console.WriteLine("-------------------------------------");
            CustumerManager custumerManager = new CustumerManager();
            custumerManager.Add(customer1);
            custumerManager.Remove(customer2);
            custumerManager.Listing(customer1);


        }
    }
}
