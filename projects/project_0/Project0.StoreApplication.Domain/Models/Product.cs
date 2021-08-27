

namespace Project0.StoreApplication.Domain.Models
{

  public class Product
  {
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product()
    {
      Name = "Generic CPU";
      Price = 99.99m;
    }

    public override string ToString()
    {
      return Name;
    }
  }
}