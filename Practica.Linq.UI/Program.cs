using Practica.EF.Entities;
using Practica.EF.Logic.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinqControl linqControl = new LinqControl();
            
            /*
            //1.
            var oneCustomer = linqControl.GetCustomers();
            Console.WriteLine(oneCustomer.First().ToString()); 
            Console.ReadKey();
            
            //2.
            var products = linqControl.GetProductsWithoutStock();
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName.ToString());
            }
            
            //3.
            
            foreach (var product in linqControl.GetProductsWithStock3Units())
            {
                Console.WriteLine(product.ProductName.ToString());
            }
            
            //4.
            foreach (var customer in linqControl.GetCustomersRegionWA())
            {
                Console.WriteLine(customer.ContactName.ToString());
            }
            
            //5.

            //6.
            foreach (var customer in linqControl.GetCustomersName())
            {
                Console.WriteLine(customer.ContactName.ToString().ToLower());
            }
            foreach (var customer in linqControl.GetCustomersName())
            {
                Console.WriteLine(customer.ContactName.ToString().ToUpper());
            }
            */
            //7
            foreach (var orders in  linqControl.GetJoinCustomersAndOrders())
            {
                Console.WriteLine(orders.ToString());
            }
            Console.ReadKey();

        }
    }
}
