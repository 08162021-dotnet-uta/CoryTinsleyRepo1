using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{

  public class Customer
  {
    public string Name { get; set; }
    //public List<Order> Orders { get; private set; }
    public Customer()
    {

    }
    public Customer(string name)
    {
      Name = name;
    }


    public override string ToString()
    {
      return $"{Name} with  Orders so far";
    }
  }
}
//{Orders.Count}