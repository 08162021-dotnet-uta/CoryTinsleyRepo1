

using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;

namespace Project0.StoreApplication.Domain.Models
{

  public class Order
  {

    public Store MyStore { get; set; }
    public Customer MyCustomer { get; set; }
    public List<Product> Products { get; set; }

    public Order()
    {


    }

  }

}