using ShoeAppBL;
using ShoeAppModel;

public class AddCustomer : IMenu
{
    public static Customer custobj = new Customer();

    //=====Dependency Injection Pattern=====
    private ICustomerBL _custBL;
public AddCustomer(ICustomerBL c_custBL)
{
    _custBL = c_custBL;
}

    //======================================

    public void Display()
    {
        
        Console.WriteLine("Please enter the customers information by following the next few questions");
        Console.WriteLine("What is the Customers name?");
        custobj.Name = Console.ReadLine();
        Console.WriteLine("What is the Customer Email?");
        custobj.Email = Console.ReadLine();
        Console.WriteLine("What is the customer Address?");
        custobj.Address = Console.ReadLine();
        Console.WriteLine("What is the Customer Phone number?");
        custobj.Phonenumber = Console.ReadLine();
        // Console.WriteLine("What is the CustomerID?");

        // try
        // {
        //     custobj.CustomerID = Convert.ToInt32(Console.ReadLine());
        // }
        // catch (System.Exception)
        // {
        //     Console.WriteLine("CustomerID Cannot be negative!");
        //     custobj.CustomerID = 1;
            
        // }
        
        Console.WriteLine("[1] - Add new Customer");
        Console.WriteLine("[0] - Exit");
    }

    public string Yourchoice()
    {
        string userInput = Console.ReadLine();
        
        if (userInput == "1")
        {
            Customer foundCustomer = _custBL.SearchCustomerByName(custobj.Name);
            if (foundCustomer == null)
            {
                _custBL.AddCustomer(custobj);
                
            }
                return "MainMenu";
        //    try
        //    {
        //        _custBL.AddCustomer(custobj);
        //    }
        //    catch (System.Exception)
        //    {
               
        //        Console.WriteLine("Customer name already exist!");
        //        Console.ReadLine();
        //    }
        }
        else if (userInput == "0")
        {
            return "Exit";
        }
        else
        {
            Console.WriteLine("Please enter a correct response");
            return "AddCustomer";
        }
    }
}