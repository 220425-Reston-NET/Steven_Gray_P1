using ShoeAppBL;
using ShoeAppModel;

namespace ShoeAppUI
{
    public class SelectInventory : IMenu
    {

        private IInventoryBL _inventoryBL;
        public SelectInventory(IInventoryBL c_inventoryBL)
        {
            _inventoryBL = c_inventoryBL;
        }
        public void Display()
        {
           List<Inventory> listofInventory = _inventoryBL.GetAllInventory();
           foreach (Inventory inventoryobj in listofInventory)
           {
               Console.WriteLine(inventoryobj);
           }
        }

        public string Yourchoice()
        {
            throw new NotImplementedException();
        }
    }
}