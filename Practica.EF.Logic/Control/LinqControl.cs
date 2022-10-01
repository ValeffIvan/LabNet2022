using Practica.EF.Entities;
using Practica.EF.Logic.Logic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Control
{
    public class LinqControl
    {
        CustomersLogic customersLogic = new CustomersLogic();
        ProductsLogic productsLogic = new ProductsLogic();
        OrdersLogic ordersLogic = new OrdersLogic();

        //1
        public IEnumerable<Customers> GetCustomers()
        {
            var query = (from Customers in customersLogic.GetAll()
                         where Customers.CustomerID == "ANTON"
                         orderby Customers.CustomerID descending
                         select Customers);
            return query;

        }
        //2
        public IEnumerable<Products> GetProductsWithoutStock()
        {
            var query = (from Product in productsLogic.GetAll()
                         where Product.UnitsInStock == 0
                         orderby Product.ProductName ascending
                         select Product);

            return query;
        }
        //3
        public IEnumerable<Products> GetProductsWithStock3Units()
        {
            var query = productsLogic.GetAll().Where(p => p.UnitsInStock > 0 && p.UnitPrice >= 3)
                                              .OrderBy(p => p.ProductName)
                                              .Select(p => p);
            return query;
        }
        //4
        public IEnumerable<Customers> GetCustomersRegionWA()
        {
            var query = customersLogic.GetAll().Where(c => c.Region == "WA")
                                              .OrderBy(c => c.ContactName)
                                              .Select(c => c);
            return query;
        }
        //5

        public IEnumerable<Products> GetElementOrNull()
        {
            var query = productsLogic.GetAll().Where(p => p.ProductID == 789)
                                              .OrderBy(p => p.ProductName)
                                              .Select(p => p);
            return query;
        }

        //6
        public IEnumerable<Customers> GetCustomersName()
        {
            var query = (from Customers in customersLogic.GetAll()
                         orderby Customers.ContactName ascending
                         select Customers);
            return query;
        }

        //7
        public IEnumerable<Orders> GetJoinCustomersAndOrders()
        {
            DateTime date_1 = new DateTime(1997, 01, 01);
            var query = (from orders in ordersLogic.GetAll()
                         join customers in customersLogic.GetAll()
                         on orders.CustomerID equals customers.CustomerID
                         where customers.Region == "WA" && orders.OrderDate >= date_1
                         orderby orders.OrderID ascending
                         select orders);
            return query;
        }

        //8
        public IEnumerable<Customers> GetFirst3CustomersRegionWA()
        {
            var query = customersLogic.GetAll().Where(c => c.Region == "WA")
                                              .OrderBy(c => c.CustomerID)
                                              .Select(c => c);
            return query;
        }

        //9
        public IEnumerable<Products> GetProductOrderByName()
        {
            var query = productsLogic.GetAll().OrderBy(p => p.ProductName)
                                               .Select(p => p);
            return query;
        }

        //10
        public IEnumerable<Products> GetProductOrderByUnitInStock()
        {
            var query = (from Products in productsLogic.GetAll()
                         orderby Products.UnitsInStock descending
                         select Products);
            return query;
        }

        //11
        public IEnumerable<Products> GetProductsWithCategory()
        {
            var query = (from Products in productsLogic.GetAll()
                         orderby Products.ProductID ascending
                         select Products);
            return query;
        }

        //12
        public IEnumerable<Products> GetFirstElementProducts()
        {
            var query = (from Products in productsLogic.GetAll()
                         orderby Products.ProductID ascending
                         select Products);
            return query;
        }


    }
}
