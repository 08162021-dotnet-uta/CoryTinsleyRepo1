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

    public StoreRepository()
    {

      var ComputerStore = new ComputerStore();
      var MusicStore = new MusicStore();
      var


      if (_fileAdapter.ReadFromFile<Store>(_path) == null)
      {
        _fileAdapter.WriteToFile<Store>(_path, new List<Store>());
      }


    }


    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(List<Store> entry)
    {
      _fileAdapter.WriteToFile<Store>(_path, entry);

      return true;
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