using System.Text.Json;
using ShoeAppModel;

namespace ShoeAppDL
{
    public class CustomerRepository : IRepository<Customer>
    {
        private string _filepath = "../ShoeAppDL/Data/Customer.json";

        public void Add(Customer c_Cust )
        {
           List<Customer> listofcustomer = GetAll();
           listofcustomer.Add(c_Cust);

           string jsonString = JsonSerializer.Serialize(listofcustomer, new JsonSerializerOptions{WriteIndented = true});
           File.WriteAllText(_filepath, jsonString);

           
        }

        public List<Customer> GetAll()
        {
            string jsonString = File.ReadAllText(_filepath);
            List<Customer> ListofCustomer = JsonSerializer.Deserialize<List<Customer>>(jsonString);

            return ListofCustomer;
        }
    }

}
