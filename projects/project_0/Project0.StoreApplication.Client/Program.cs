using System;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Storage.Repositories;
using Project0.StoreApplication.Client.Singletons;
using Project0.StoreApplication.Domain.Models;
using Serilog;

namespace Project0.StoreApplication.Client
{

  /// <summary>
  /// Defines the Program Class
  /// </summary>
  class Program
  {

    private readonly StoreRepository _storeRepo = StoreRepository.GetInstance();
    private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
    private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
    private static readonly CustomerRepository _customerRepo = new CustomerRepository();
    private static readonly ProductSingleton _productSingleton = ProductSingleton.Instance;
    private static readonly ProductRepository _productRepo = new ProductRepository();
    private static List<string> confirmationList = new List<string>() { "Yes", "No" };


    private const string _logFilePath = @"/home/clypto/revature/training_code/projects/data/logs.txt";

    private static void Main(string[] args)
    {
      Log.Logger = new LoggerConfiguration().WriteTo.File(_logFilePath).CreateLogger();

      Run();
    }




    private static void Run()
    {

      //saves customer the user selects 
      var customer = _customerSingleton.Customers[CaptureOutput<Customer>(_customerSingleton.Customers) - 1];
      Console.WriteLine("You selected: " + customer);

      //saves store the user selects
      var store = _storeSingleton.Stores[CaptureOutput<Store>(_storeSingleton.Stores) - 1];


      var products = _productSingleton.SortProducts(store);
      var selectedProduct = CaptureOutput<Product>(products) - 1;

      Console.WriteLine($"Do you want to buy {products[selectedProduct]}");
      var choice = CaptureOutput<string>(confirmationList) - 1;

      if (choice == 1)
        //Place code for order

        Console.WriteLine(customer);
    }



    /// <summary>
    /// Print list to console
    /// </summary>
    /// <typeparam name="T"></typeparam>
    static void ConsoleOutput<T>(List<T> data) where T : class
    {
      int i = 1;
      Log.Information($"Method Output<{typeof(T)}>");

      foreach (var item in data)
      {
        System.Console.WriteLine($"{i++} - {item}");
        //i += 1;
      }
    }



    /// <summary>
    /// Capture User input
    /// </summary>
    /// <typeparam name="T"></typeparam>
    static private int CaptureOutput<T>(List<T> data) where T : class
    {

      ConsoleOutput<T>(data);

      Console.WriteLine($"Select {typeof(T).Name}: ");

      int selected = int.Parse(Console.ReadLine());



      return selected;
    }
  }
}
