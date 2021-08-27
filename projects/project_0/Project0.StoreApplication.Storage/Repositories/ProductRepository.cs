using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  /// <summary>
  /// 
  /// </summary>
  public class ProductRepository : IRepository<Product>
  {
    private const string _path = @"/home/clypto/revature/training_code/projects/data/products.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    public ProductRepository()
    {
      if (_fileAdapter.ReadFromFile<Product>(_path) == null)
      {
        _fileAdapter.WriteToFile<Product>(_path, new List<Product>());
      }
    }


    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Product entry)
    {
      _fileAdapter.WriteToFile<Product>(_path, new List<Product> { entry });

      return true;
    }


    public List<Product> Select()
    {
      return _fileAdapter.ReadFromFile<Product>(_path);
    }


    public Store Update()
    {
      throw new System.NotImplementedException();
    }

    Product IRepository<Product>.Update()
    {
      throw new System.NotImplementedException();
    }
  }
}