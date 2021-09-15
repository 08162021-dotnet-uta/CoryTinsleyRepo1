using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Interfaces;



namespace Project0.StoreApplication.Storage.Models.Mapping
{
    class CustomerMapper : IModelMapper<Customer, Customer_D>
    {
        public Customer_D ModelToViewModel(Customer entry)
        {
            Customer_D c = new Customer_D();
            c.CustomerID = entry.CustomerId;
            c.Name = entry.Name;
            return c;
        }

        public Customer ViewModelToModel(Customer_D entry)
        {
            Customer c = new Customer();
            c.Name = entry.Name;
            return c;
        }
    }
}
