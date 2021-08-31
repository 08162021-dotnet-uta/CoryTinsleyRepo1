

namespace Project0.StoreApplication.Domain.Models
{

  public class Product
  {
    public string Name { get; set; }
    public decimal Price { get; set; }

    public int StoreID { get; set; }

    public Product()
    {

    }
    public Product(string name, decimal price, int i)
    {
      Name = name;
      Price = price;
      StoreID = i;

    }

    public override string ToString()
    {
      return Name;
    }
  }
}