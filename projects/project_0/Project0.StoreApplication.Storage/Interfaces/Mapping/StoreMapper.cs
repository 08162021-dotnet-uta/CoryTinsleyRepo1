//using Project0.StoreApplication.Domain.Abstracts;
//using Project0.StoreApplication.Domain.Models;
//using Project0.StoreApplication.Storage.Interfaces;



//namespace Project0.StoreApplication.Storage.Models.Mapping
//{
//    class StoreMapper : IModelMapper<Store, Store_D>
//    {
//        public Store_D ModelToViewModel(Store entry)
//        {
//            //TODO find out how to use generics with abstract store 
//            Store_D c = new ComputerStore();
//            //c.StoreID = entry.StoreId;
//            //c.Name = entry.Name;
//            return c;
//        }

//        public Store ViewModelToModel(Store_D entry)
//        {
//            Store c = new Store();
//            c.Name = entry.Name;
//            return c;
//        }
//    }
//}

