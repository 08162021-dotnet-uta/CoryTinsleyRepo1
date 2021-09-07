
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.Singletons
{

  public class StoreSingleton
  {

    public static StoreSingleton _storeSingleton;
    private static readonly StoreRepository _storeRepository = StoreRepository.GetInstance();

    private static readonly ProductSingleton _productSingleton = ProductSingleton.Instance;


    public Dictionary<Store, int> storeDictionary = new Dictionary<Store, int>();
    public List<Store> Stores { get; set; }

    public List<Product> Products { get; set; }

    public static StoreSingleton Instance
    {
      get
      {

        if (_storeSingleton == null)
          _storeSingleton = new StoreSingleton();

        return _storeSingleton;
      }

    }

    private StoreSingleton()
    {
      Stores = _storeRepository.Select();
    }

    public void Add(Store Store)
    {
      _storeRepository.Insert(Store);
      Stores = _storeRepository.Select();
    }

    public void AddProducts(Product Product)
    {

    }


  }
}