using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.Singletons
{
  /// <summary>
  /// 
  /// </summary>
  public class OrderSingleton
  {
    private static OrderSingleton _orderSingleton;
    private static readonly OrderRepository _orderRepository = new OrderRepository();
    /// <summary>
    /// List of Order Objects
    /// </summary>
    /// <value></value>
    public List<Order> Orders { get; private set; }
    public static OrderSingleton Instance
    {
      get
      {
        if (_orderSingleton == null)
        {
          _orderSingleton = new OrderSingleton();
        }

        return _orderSingleton;
      }
    }


    private OrderSingleton()
    {
      Orders = _orderRepository.Select();
    }

    /// <summary>
    /// Creates order Object before storing
    /// </summary>
    /// <param name="products"></param>
    /// <param name="store"></param>
    /// <param name="customer"></param>
    public void CreateOrder(List<Product> products, Store store, Customer customer)
    {

      var order = new Order(products, store, customer);
      Add(order);

    }


    /// <summary>
    /// Add order object to List
    /// </summary>
    /// <param name="order"></param>
    public void Add(Order order)
    {
      _orderRepository.Insert(order);
      Orders = _orderRepository.Select();
    }
  }
}