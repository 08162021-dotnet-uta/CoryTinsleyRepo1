using System.Collections.Generic;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{

  public class CustomerRepository : IRepository<Customer>
  {
    private const string _path = @"C:/Users/cwall/source/repos/08162021-dotnet-uta/CoryTinsleyRepo1/projects/data/Customers.xml";

    public List<Customer> Customers { get; set; }
    private static readonly FileAdapter _fileAdapter = new FileAdapter();
    private static readonly EF_Customers _ef_Customers = new EF_Customers();



        public CustomerRepository()
    {





      if (_fileAdapter.ReadFromFile<Customer>(_path) == null)
      {
        _fileAdapter.WriteToFile<Customer>(_path, new List<Customer>()
        {
          //new Customer("Clypto"),
          //new Customer("Sam"),
          //new Customer("Ryan")

        });
      }

      Customers = Select();


    }




    public bool Delete(Customer entry)
    {
      Customers.Remove(entry);
      return true;
    }

    public bool Insert(Customer entry)
    {
      Customers.Add(entry);
            //_fileAdapter.WriteToFile<Customer>(_path, Customers);
            _ef_Customers.SetCustomer(entry);

      return true;
    }


    public List<Customer> Select()
    {
            //return _fileAdapter.ReadFromFile<Customer>(_path);
            return _ef_Customers.GetCustomers();
    }

    public Customer Update(Customer entry)
    {
      Delete(entry);
      Customers.Add(entry);
      _fileAdapter.WriteToFile<Customer>(_path, Customers);
      return entry;
    }
  }
}