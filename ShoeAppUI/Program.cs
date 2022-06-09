// // See https://aka.ms/new-console-template for more information
// using ShoeAppModel;

// Console.WriteLine("Hello, World!");

// Shoes Shoeobj = new Shoes();
// Shoeobj.SizeID  = 100;

// Inventory inv1 = new Inventory();
// inv1.name = "Gucci";
// Inventory inv2 = new Inventory();
// inv2.name = "Chanel";
// Inventory inv3 = new Inventory();
// inv3.name = "Balenciaga";
// Inventory inv4 = new Inventory();
// inv4.name = "Dior";

// // Shoeobj.Inventories = new List<Inventory>();

// Shoeobj.Inventories.Add(inv1);
// Shoeobj.Inventories.Add(inv2);
// Shoeobj.Inventories.Add(inv3);
// Shoeobj.Inventories.Add(inv4);

// foreach (Inventory item in Shoeobj.Inventories)
// {
//     Console.WriteLine(item.Name);
// }

using ShoeAppBL;
using ShoeAppDL;
using ShoeAppUI;

Console.Clear();

IMenu menu = new MainMenu();

bool repeat = true;

while(repeat)
{
    Console.Clear();
    menu.Display();
    string ans = menu.Yourchoice();

    if (ans == "MainMenu")
    {
        menu = new MainMenu();
    }
    else if (ans == "AddCustomer")
    {
        menu = new AddCustomer(new CustomerBL(new SQLCustomerRepository()));
    }
    else if (ans == "SearchCustomer")
    {
        menu = new SearchCustomer(new CustomerBL(new SQLCustomerRepository()));
    }
    else if (ans == "SelectInventory")
    {
        menu = new SelectInventory(new InventoryBL(new InventoryRepository())); new CustomerBL(new SQLCustomerRepository());
    }
   
    else if (ans == "Exit")
    {
        repeat = false;
    }

}

