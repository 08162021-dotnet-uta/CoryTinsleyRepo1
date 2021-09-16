using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Interfaces;



namespace Project0.StoreApplication.Storage.Models.Mapping
{
    class StoreMapper : IModelMapper<Store, Store_D>
    {

        public static StoreMapper _storeMapper;
        public static StoreMapper Instance
        {
            get
            {
                if (_storeMapper == null)
                {
                    _storeMapper = new StoreMapper();
                }


                return _storeMapper;
            }
        }
        public Store_D ModelToViewModel(Store entry)
        {
            //TODO find out how to use generics with abstract store 
            switch(entry.Name)
            {
                case "ComputerStore":
                    ComputerStore s = new ComputerStore();
                    s.StoreID = entry.StoreId;
                    s.Name = entry.Name;
                    return s;
                case "PenStore":
                    PenStore s1 = new PenStore();
                    s1.StoreID = entry.StoreId;
                    s1.Name = entry.Name;
                    return s1;
                case "MusicStore":
                    MusicStore s2 = new MusicStore();
                    s2.StoreID = entry.StoreId;
                    s2.Name = entry.Name;
                    return s2;
                default:
                    return null;

            }
            
        }

        public Store ViewModelToModel(Store_D entry)
        {
            Store c = new Store();
            c.Name = entry.Name;
            return c;
        }
    }
}

