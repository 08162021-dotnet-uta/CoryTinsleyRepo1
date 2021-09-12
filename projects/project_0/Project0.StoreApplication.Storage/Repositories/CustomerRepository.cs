using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;
using Project0.StoreApplication.Storage.Models;

namespace Project0.StoreApplication.Storage.Repositories
{

  public class CustomerRepository : IRepository<Customer>
  {
    private const string _path = @"C:/Users/cwall/source/repos/08162021-dotnet-uta/CoryTinsleyRepo1/projects/data/Customers.xml";

    public List<Customer_D> Customers { get; set; }
    private static readonly FileAdapter _fileAdapter = new FileAdapter();
    private static readonly StoreApplicationDBContext saDBContext = new StoreApplicationDBContext();



        public CustomerRepository()
    {





          if (_fileAdapter.ReadFromFile<Customer_D>(_path) == null)
          {
            _fileAdapter.WriteToFile<Customer_D>(_path, new List<Customer_D>()
            {
              //new Customer("Clypto"),
              //new Customer("Sam"),
              //new Customer("Ryan")

            });
          }

            //Customers = Select();


    }




    public bool Delete(Customer entry)
    {
      //Customers.Remove(entry);
      return true;
    }

    public bool Insert(Customer entry)
    {
      //Customers.Add(entry);
            //_fileAdapter.WriteToFile<Customer>(_path, Customers);
            //_ef_Customers.SetCustomer(entry);

      return true;
    }


    public List<Customer> Select()
    {
            //return _fileAdapter.ReadFromFile<Customer>(_path);
            return saDBContext.Customers.FromSqlRaw("Select * from Customer;").ToList();
        }

    public Customer Update(Customer entry)
    {
      //Delete(entry);
      //Customers.Add(entry);
     // _fileAdapter.WriteToFile<Customer_D>(_path, Customers);
      return entry;
    }
  }
}