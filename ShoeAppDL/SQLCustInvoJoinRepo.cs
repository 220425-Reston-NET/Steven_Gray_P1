using Microsoft.Data.SqlClient;
using ShoeAppDL;
using ShoeAppModel;

namespace ShoeAppDL


{
    public class SQLCustInvoJoinRepo : IRepository<CustomerInventoryJoin>
    {
        private string _connectionString;
        public SQLCustInvoJoinRepo(string c_connectionString)
        {
            this._connectionString = c_connectionString;
        }
       

        public void Add(CustomerInventoryJoin c_resource)
        {
            throw new NotImplementedException();
        }

        public List<CustomerInventoryJoin> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}