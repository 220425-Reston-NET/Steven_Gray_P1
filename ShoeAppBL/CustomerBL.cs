
using ShoeAppDL;
using ShoeAppModel;

namespace ShoeAppBL
{
    public class CustomerBL : ICustomerBL
    {

        private IRepository<Customer> _custRepo;

        public CustomerBL(IRepository<Customer> c_custRepo)
        {
            _custRepo = c_custRepo;
        }
        public void AddCustomer(Customer c_Cust)
        {
            Customer foundedCustomer = SearchCustomerByName(c_Cust.Name);
           if (foundedCustomer == null)
           {
               _custRepo.Add(c_Cust);
           }
           else
           {
               throw new Exception("Customer name already exist");
           }
           

           
        }

        public void AddInventorytoCustomer(Customer c_customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomer()
        {
            return _custRepo.GetAll();
        }

        public Customer SearchCustomerByAddress(string c_CustAddress)
        {
           List<Customer> currentListOfCustomer = _custRepo.GetAll();
           
           foreach (Customer custobj in currentListOfCustomer)
           {
               if (custobj.Address == c_CustAddress)
               {
                   return custobj;
               }
           }
           
                return null;

        }

        public Customer SearchCustomerByCustomerID(int c_CustID)
        {
            List<Customer> currentListOfCustomer = _custRepo.GetAll();
           
           foreach (Customer custobj in currentListOfCustomer)
           {
               if (custobj.CustomerID == c_CustID)
               {
                   return custobj;
               }
           
           
            }
                 return null;
        }        

        public Customer SearchCustomerByEmail(string c_CustEmail)
        {
             List<Customer> currentListOfCustomer = _custRepo.GetAll();
           
           foreach (Customer custobj in currentListOfCustomer)
           {
               if (custobj.Email == c_CustEmail)
               {
                   return custobj;
               }
            
                
                
            }
                 return null;
        }         

        public Customer SearchCustomerByName(string c_CustName)
        {
            List<Customer> currentListOfCustomer = _custRepo.GetAll();
           
           foreach (Customer custobj in currentListOfCustomer)
           {
               if (custobj.Name == c_CustName)
               {
                   return custobj;
               }
           
           
            }
                return null;
        }    

        public Customer SearchCustomerByPhoneNumber(string c_custPhoneNumber)
        {
             List<Customer> currentListOfCustomer = _custRepo.GetAll();
           
           foreach (Customer custobj in currentListOfCustomer)
           {
               if (custobj.Phonenumber == c_custPhoneNumber)
               {
                   return custobj;
               }
            
            }
                return null;
        }
    } 

}       
        