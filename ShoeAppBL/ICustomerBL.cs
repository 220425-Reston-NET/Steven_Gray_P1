using ShoeAppModel;

namespace ShoeAppBL
{
  /// <summary>
  /// Business layer responsible for further validation or process of data obtained from the database or the user
  /// what kind of process? that all depends on the type of functionality you will be doing
  /// </summary>
    public interface ICustomerBL
    {
        /// <summary>
        /// Add customer to the database
        /// </summary>
        /// <param name="c_Cust"></param>
        /// <returns>Gives back the customer that gets added to the DB</returns>
       void AddCustomer(Customer c_Cust);

     
       Customer SearchCustomerByName(string c_CustName);

      

  /// <summary>
  /// Will give current customer in the Database
  /// </summary>
  /// <returns>List object that holds customer</returns>

        void AddInventorytoCustomer(Customer c_customer);
        List<Customer> GetAllCustomer();
    }

}



