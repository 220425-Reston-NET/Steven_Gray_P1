using ShoeAppBL;
using ShoeAppModel;

public class SearchCustomer : IMenu
{

    private ICustomerBL _custBL;
    public SearchCustomer(ICustomerBL c_custBL)
    {
        _custBL = c_custBL;
    }
    public void Display()
    {
        Console.WriteLine("How would you like to look up the Customers Information?");
        Console.WriteLine("[1] - Search by Name");
        Console.WriteLine("[2] - Search by Email address");
        Console.WriteLine("[3] - Search by Address");
        Console.WriteLine("[4] - Search by Phone Number");
        Console.WriteLine("[5] - Search by CustomerID");
        Console.WriteLine("[6] - Exit");

    }

    public string Yourchoice()
    {
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            Console.WriteLine("Enter a valid Customer Name:");
            string custName = Console.ReadLine();
            
            Customer foundedCustomer = _custBL.SearchCustomerByName(custName);

            if (foundedCustomer == null)
            {
                Console.WriteLine("Customer Not Found!!");
            }
            else
            {
                Console.WriteLine("====Customer Info====");
                Console.WriteLine("Name: "+ foundedCustomer.Name);
                Console.WriteLine("Email:" + foundedCustomer.Email);
                Console.WriteLine("Address:" + foundedCustomer.Address);
                Console.WriteLine("Phone Number:" + foundedCustomer.Phonenumber);
                Console.WriteLine("CustomerID:" + foundedCustomer.CustomerID);
                Console.WriteLine("====================");
                Console.WriteLine(" Do you want to add a Shoe Inventory to this customer? Y - for Yes N - No");
                string addCustomerChoice = Console.ReadLine();
                if (addCustomerChoice == "Y")   
                {
                    return "SelectInventory";
                }
                else
                {
                    return "SearchCustomer";

                } 
                    
            }
            Console.ReadLine();
            return "SearchCustomer";


            
           
            
        }
        else if (userInput == "2")
        {
            Console.WriteLine("Enter a valid Email Address:");
            string custEmail = Console.ReadLine();
            

            return "MainMenu";
        }
        else if (userInput == "3")
        {
            Console.WriteLine("Enter a valid Address:");
            string custAddress = Console.ReadLine();

            return "MainMenu";
        }
        else if (userInput == "4")
        {

            Console.WriteLine("Enter a valid Phone Number:");
            string custPhoneNumber = Console.ReadLine();
            return "MainMenu";
        }
        else if (userInput == "5")
        {

            Console.WriteLine("Enter a valid Customer Number:");
            string custCustomerNumber = Console.ReadLine();
            return "MainMenu";
        }
        else if (userInput == "6")
        {
            return "MainMenu";
        }
        else
        {
            Console.WriteLine("Please enter a valid response");
            return "SearchCustomer";
        }
    }
}