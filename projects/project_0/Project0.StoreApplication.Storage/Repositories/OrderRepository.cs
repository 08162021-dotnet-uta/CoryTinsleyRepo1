using System.Collections.Generic;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{

  public class OrderRepository : IRepository<Order>
  {
    private const string _path = @"/home/clypto/revature/training_code/projects/data/Orders.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    public OrderRepository()
    {
      if (_fileAdapter.ReadFromFile<Order>(_path) == null)
      {
        _fileAdapter.WriteToFile<Order>(_path, new List<Order>());
      }
    }


    public bool Delete()
    {
      throw new System.NotImplementedException();
    }


    public bool Insert(Order entry)
    {
      _fileAdapter.WriteToFile<Order>(_path, new List<Order> { entry });

      return true;
    }


    public List<Order> Select()
    {
      return _fileAdapter.ReadFromFile<Order>(_path);
    }

    public Order Update()
    {
      throw new System.NotImplementedException();
    }
  }
}