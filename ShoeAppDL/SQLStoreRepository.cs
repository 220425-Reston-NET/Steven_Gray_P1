using Microsoft.Data.SqlClient;
using ShoeAppModel;

namespace ShoeAppDL
{
    public class SQLStoreRepository : IRepository<Store>
    {
        //=================== Dependency Injection ==========================
        private string _connectionString;
        
        public SQLStoreRepository(string c_connectionString)
        {
            this._connectionString = c_connectionString;
        }
        
        //=====================Dependency Injection ========================
        public void Add(Store c_resource)
        {
            throw new NotImplementedException();
        }

        public List<Store> GetAll()
        {
            string SqlQuery = @"select * from Store";
            List<Store> listOfCurrentStore = new List<Store>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SqlQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfCurrentStore.Add(new Store(){
                       Id = reader.GetInt32(0),
                       Name = reader.GetString(1),
                       Products = GetProductsFromAStore(reader.GetInt32(0))
                    });
                }
            }

            return listOfCurrentStore;

        }

        private List<Product> GetProductsFromAStore(int c_sId)
        {
            string SqlQuery = @"select s.sName, i.Quantity, p.pId, p.pName from Store s
                                inner join Inventory i on s.sId = i.sId
                                inner join Product p on i.pId = p.pId
                                where s.sId = @storeId";

            List<Product> listOfCurrentProduct = new List<Product>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SqlQuery, con);

                command.Parameters.AddWithValue("@storeId", c_sId);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfCurrentProduct.Add(new Product(){
                        Id = reader.GetInt32(2),
                        Name = reader.GetString(3),
                        Quantity = reader.GetInt32(1)
                    });
                }
            }

            return listOfCurrentProduct;
        }

        public Task<List<Store>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Store c_resource)
        {
            throw new NotImplementedException();
        }
    }
}