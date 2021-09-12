using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Storage.Adapters;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Storage.Repositories
{
  /// <summary>
  /// 
  /// </summary>
  public class StoreRepository : IRepository<Store_D>
  {
    private const string _path = @"/home/clypto/revature/training_code/projects/data/stores.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();


    private StoreRepository()
    {
      if (_fileAdapter.ReadFromFile<Store_D>(_path) == null)
      {
        _fileAdapter.WriteToFile<Store_D>(_path, new List<Store_D>()
        {
          new ComputerStore(),
          new PenStore(),
          new MusicStore()
        });
      }
    }



    private static StoreRepository _storeRepository;

    public static StoreRepository GetInstance()
    {

      if (_storeRepository == null)
      {
        _storeRepository = new StoreRepository();
      }

      return _storeRepository;
    }


    public bool Delete(Store_D entry)
    {
      throw new System.NotImplementedException();
    }


    public bool Insert(Store_D entry)
    {
      _fileAdapter.WriteToFile<Store_D>(_path, new List<Store_D> { entry });

      return true;
    }


    public List<Store_D> Select()
    {
      return _fileAdapter.ReadFromFile<Store_D>(_path);
    }


    public Store_D Update(Store_D entry)
    {
      throw new System.NotImplementedException();
    }
  }
}