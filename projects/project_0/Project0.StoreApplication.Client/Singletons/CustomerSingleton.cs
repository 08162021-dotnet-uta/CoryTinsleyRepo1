using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.Singletons
{
  /// <summary>
  /// 
  /// </summary>
  public class CustomerSingleton
  {
    private static CustomerSingleton _customerSingleton;
    private static readonly CustomerRepository _customerRepository = new CustomerRepository();
    /// <summary>
    /// List of Customer Objects
    /// </summary>
    /// <value></value>
    public List<Customer> Customers { get; private set; }
    public static CustomerSingleton Instance
    {
      get
      {
        if (_customerSingleton == null)
        {
          _customerSingleton = new CustomerSingleton();
        }


        return _customerSingleton;
      }
    }


    private CustomerSingleton()
    {

      Customers = _customerRepository.Select();
    }

    /// <summary>
    /// Add customer object to XML
    /// </summary>
    /// <param name="customer"></param>
    public void Add(Customer customer)
    {
      _customerRepository.Insert(customer);
      Customers = _customerRepository.Select();

    }

    public void UpdateCustomer(Customer customer)
    {
      _customerRepository.Update(customer);
    }
  }
}