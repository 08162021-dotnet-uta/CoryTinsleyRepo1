

using System;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;

namespace Project0.StoreApplication.Domain.Models
{

  public class Order
  {
    //public Store StoreID { get; set; }
    public short OrderID { get; set; }
    public byte StoreKey { get; set; }
    //public Customer CustomerID { get; set; }
    public byte CustomerID { get; set; }
    //public List<Product> Products { get; set; }
    public DateTime OrderDate { get; set; }


    public Order()
    {
        
    }

    public Order( byte CKey, byte SKey)
    {

      //CustomerID = customer;
      //StoreID = store;
      //Products = products;

      OrderDate = DateTime.Now;
      StoreKey = SKey;
      CustomerID = CKey;


    }

  }

}