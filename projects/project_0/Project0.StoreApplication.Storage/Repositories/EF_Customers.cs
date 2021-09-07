using Microsoft.EntityFrameworkCore;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;
using System.Collections.Generic;
using System.Linq;

namespace Project0.StoreApplication.Storage.Repositories
{
    class EF_Customers
    {
        private readonly DataAdapter _da = new DataAdapter();

        public List<Customer> GetCustomers()
        {
            return _da.Customers.FromSqlRaw("Select * from Customer;").ToList();
        }

        public void SetCustomer(Customer customer)
        {
            _da.Database.ExecuteSqlRaw("insert into Customer(Name) values ({0});", customer.Name);
        }
    }
}
