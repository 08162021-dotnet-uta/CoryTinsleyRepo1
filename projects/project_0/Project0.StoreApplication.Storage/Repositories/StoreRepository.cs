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
  public class StoreRepository : IRepository<Store>
  {
    private const string _path = @"/home/clypto/revature/training_code/projects/data/stores.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();


    private StoreRepository()
    {




      if (_fileAdapter.ReadFromFile<Store>(_path) == null)
      {
        _fileAdapter.WriteToFile<Store>(_path, new List<Store>()
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


    public bool Delete()
    {
      throw new System.NotImplementedException();
    }


    public bool Insert(Store entry)
    {
      _fileAdapter.WriteToFile<Store>(_path, new List<Store> { entry });

      return true;
    }


    public List<Store> Select()
    {
      return _fileAdapter.ReadFromFile<Store>(_path);
    }


    public Store Update()
    {
      throw new System.NotImplementedException();
    }
  }
}