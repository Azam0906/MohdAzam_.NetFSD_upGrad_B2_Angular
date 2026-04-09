using System.Data;
using Microsoft.Data.SqlClient;
using AdoDemo.Entity;

namespace AdoDemo.DataAccess
{
    public class ProductRepository
    {
        private readonly string _connectionString;

        public ProductRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int AddProduct(Product product)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand("sp_InsertProduct", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductName", SqlDbType.VarChar, 100).Value = product.ProductName;
                cmd.Parameters.Add("@Category", SqlDbType.VarChar, 50).Value = product.Category;
                cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = product.Price;

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public List<Product> GetAllProducts()
        {
            List<Product> list = new List<Product>();

            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand("sp_GetAllProducts", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                using SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Product
                    {
                        ProductId = Convert.ToInt32(dr["ProductId"]),
                        ProductName = dr["ProductName"].ToString(),
                        Category = dr["Category"].ToString(),
                        Price = Convert.ToDecimal(dr["Price"])
                    });
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list;
        }

        public int UpdateProduct(Product product)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand("sp_UpdateProduct", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = product.ProductId;
                cmd.Parameters.Add("@ProductName", SqlDbType.VarChar, 100).Value = product.ProductName;
                cmd.Parameters.Add("@Category", SqlDbType.VarChar, 50).Value = product.Category;
                cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = product.Price;

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int DeleteProduct(int id)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand("sp_DeleteProduct", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = id;

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

    }
}
