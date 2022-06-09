using ShoeAppModel;

namespace ShoeAppBL
{
    public interface IInventoryBL
    {
        List<Inventory> GetAllInventory();

        Inventory SearchInventoryByName(string c_InventoryName);
    }
}