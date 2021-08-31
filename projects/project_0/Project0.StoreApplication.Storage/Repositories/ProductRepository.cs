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
        _fileAdapter.WriteToFile<Product>(_path, new List<Product>()
        {
          new Product("Generic CPU", 59.99m, 1),
          new Product("Generic GPU", 100.00m, 1),
          new Product("Super Fancy Case", 1000.00m, 1),

          new Product("Pack of Ballpoint Pens", 5.00m, 2),
          new Product("One of those fancy pens that you dip in ink", 5000.00m, 2),

          new Product("CD that catches on fire if you use it", 5.55m, 3),
          new Product("Broken pair of branded headphones", 150.00m, 3)


        });
      }

    }


    public bool Delete(Product entry)
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


    public Product Update(Product entry)
    {
      throw new System.NotImplementedException();
    }


  }
}