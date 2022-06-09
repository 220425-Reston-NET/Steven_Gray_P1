
using ShoeAppDL;
using ShoeAppModel;

namespace ShoeAppBL
{
    public class InventoryBL : IInventoryBL
    {
        private IRepository<Inventory> _inventoryRepo;

        public InventoryBL(IRepository<Inventory> c_inventoryRepo)
        {
            _inventoryRepo = c_inventoryRepo;
        }
        public List<Inventory> GetAllInventory()
        {
            return _inventoryRepo.GetAll();
        }

        public Inventory SearchInventoryByName(string c_InventoryName)
        {
             List<Inventory> currentListOfInventory = _inventoryRepo.GetAll();
             
             foreach (Inventory inventoryobj in currentListOfInventory)
             {
                 if (inventoryobj.Name == c_InventoryName)  
                 {
                     return inventoryobj;
                 }
             }

             return null;
        }
    }
    
}