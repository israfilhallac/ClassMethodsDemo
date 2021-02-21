using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodsDemo
{
    class CustumerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi :" +customer.Name);
        }
        public void Listing(Customer customer)
        {
            Console.WriteLine("Müşteri Listelendi :" +customer.SurName);
        }
        public void Remove(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi :" +customer.Id);
        }
    }
}
