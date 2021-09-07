using System;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{

  public class OrderRepository : IRepository<Order>
  {
    private const string _path = @"/home/clypto/revature/training_code/projects/data/Orders.xml";
    public List<Order> Orders { get; private set; }
    private static readonly FileAdapter _fileAdapter = new FileAdapter();
    private static readonly EF_Orders _ef_Orders = new EF_Orders();

    public OrderRepository()
    {
          //if (_fileAdapter.ReadFromFile<Order>(_path) == null)
          //{
          //  _fileAdapter.WriteToFile<Order>(_path, new List<Order>());
          //}

            Orders = Select();
    }

       
    public bool Delete(Order entry)
    {
      throw new System.NotImplementedException();
    }


    public bool Insert(Order entry)
    {
      Orders.Add(entry);

            _ef_Orders.SetOrder(entry);
      //_fileAdapter.WriteToFile<Order>(_path, Orders);

      return true;
    }

    /// <summary>
    /// Get all Order records from DB
    /// </summary>
    /// <returns></returns>
    public List<Order> Select()
    {
        List<Order> tempOrder = _ef_Orders.GetOrders();
           // Console.WriteLine(tempOrder.Count);
            return tempOrder;



      //return _fileAdapter.ReadFromFile<Order>(_path);
      
        }

    public Order Update(Order entry)
    {
      throw new System.NotImplementedException();
    }
  }
}