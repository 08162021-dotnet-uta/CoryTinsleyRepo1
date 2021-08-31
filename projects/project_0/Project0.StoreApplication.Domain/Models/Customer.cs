using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{

  public class Customer
  {
    public string Name { get; set; }
    public List<Order> Orders { get; set; }
    public Customer()
    {

    }
    public Customer(string name)
    {
      Name = name;
      if (Orders == null)
      {
        Orders = new List<Order>();
      }


    }


    public override string ToString()
    {
      return $"{Name} with {Orders.Count} Orders so far";
    }
  }
}
//