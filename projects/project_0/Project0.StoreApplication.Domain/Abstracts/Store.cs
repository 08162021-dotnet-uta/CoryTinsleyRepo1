using System.Collections.Generic;
using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Domain.Abstracts
{

  [XmlInclude(typeof(ComputerStore))]
  [XmlInclude(typeof(MusicStore))]
  [XmlInclude(typeof(PenStore))]
  public abstract class Store
  {
    public string Name { get; set; }
    public int StoreID { get; set; }

    public List<Order> Orders { get; set; }
    public List<Product> Products { get; set; }

    public Store()
    {

    }



    public override string ToString()
    {

      return Name;

    }



  }

}