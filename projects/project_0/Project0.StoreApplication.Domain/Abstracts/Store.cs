using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Domain.Abstracts
{

  public abstract class Store
  {
    public string Name { get; set; }

    public List<Order> Orders { get; set; }
    public List<Product> Products { get; set; }

    public override string ToString()
    {
      return Name;
    }

  }

}