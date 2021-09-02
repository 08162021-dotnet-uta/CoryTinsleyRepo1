using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace Project0.StoreApplication.Storage.Repositories
{
    class EF_Orders
    {

        private readonly DataAdapter _da = new DataAdapter();

        public List<Order> GetOrders()
        {
            Order order = _da.Orders.First();
            return _da.Orders.FromSqlRaw("Select * from [Order].[Order];").ToList();
        }

        public void SetOrder(Order order)
        {
            _da.Database.ExecuteSqlRaw("insert into [Order].[Order](CustomerKey, StoreKey, OrderDate) values ({0}, {1}, {2})", order.CustomerKey, order.StoreKey, order.OrderDate);
        }
    }
}