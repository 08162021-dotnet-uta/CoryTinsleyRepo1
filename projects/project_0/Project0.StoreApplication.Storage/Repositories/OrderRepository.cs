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

    public OrderRepository()
    {
      if (_fileAdapter.ReadFromFile<Order>(_path) == null)
      {
        _fileAdapter.WriteToFile<Order>(_path, new List<Order>());
      }
      Orders = Select();
    }


    public bool Delete(Order entry)
    {
      throw new System.NotImplementedException();
    }


    public bool Insert(Order entry)
    {
      Orders.Add(entry);
      _fileAdapter.WriteToFile<Order>(_path, Orders);

      return true;
    }


    public List<Order> Select()
    {
      return _fileAdapter.ReadFromFile<Order>(_path);
    }

    public Order Update(Order entry)
    {
      throw new System.NotImplementedException();
    }
  }
}