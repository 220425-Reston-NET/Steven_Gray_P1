using ShoeAppModel;
namespace ShoeAppDL
{
    public interface IInventoryRepository
    {
        void AddInventory();

        List<Inventory> GetAllInventory();
    }
}