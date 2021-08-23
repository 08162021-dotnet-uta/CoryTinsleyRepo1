using System;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Storage;
using Serilog;

namespace Project0.StoreApplication.Client
{
  class Program
  {
    static void Main(string[] args)
    {
      Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

      PrintAllStoreLocations();

      System.Console.WriteLine(SelectStore());
    }

    static void PrintAllStoreLocations()
    {
      int i = 1;

      var storeRepository = new StoreRepository();

      foreach (var store in storeRepository.Stores)
      {
        System.Console.WriteLine(i + " - " + store);
        i += 1;
      }
    }


    static Store SelectStore()
    {
      //Logger Monitoring Levels
      //verbose
      //debug
      //info
      //warn
      //error
      //fatal

      var sr = new StoreRepository().Stores;

      Console.WriteLine("Select a store: ");

      var option = int.Parse(Console.ReadLine());
      var store = sr[option - 1];

      return store;

    }
  }
}
