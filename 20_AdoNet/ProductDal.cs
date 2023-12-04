using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_AdoNet
{
    public class ProductDal
    {
        /*
        // Veri çekme işlemi Datatable az kullanılıyır kurumsal mimaride
        public DataTable GetAll()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Products;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand Command = new SqlCommand("Select * from product",conn);
            SqlDataReader reader=Command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conn.Close();
            return dataTable;
        }*/
        SqlConnection _conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Products;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand Command = new SqlCommand("Select * from product", _conn);
            SqlDataReader reader = Command.ExecuteReader();

            //Listeye verileri aktarma
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    /*Tabloda bu idleri ekle*/
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = Convert.ToString(reader["Name"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                 

                };
                products.Add(product);
            }

            reader.Close();
            _conn.Close();
            return products;
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand Command = new SqlCommand("Insert into product values(@name,@unitPrice,@stockAmount)",_conn);
            Command.Parameters.AddWithValue("@name",product.Name);
            Command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            Command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            Command.ExecuteNonQuery();

            _conn.Close ();
        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand Command = new SqlCommand("Update product set Name=@name,UnitPrice=@unitPrice,StockAmount=@stockAmount  where Id =@id ", _conn);
            Command.Parameters.AddWithValue("@id", product.Id);
            Command.Parameters.AddWithValue("@name", product.Name);
            Command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            Command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            Command.ExecuteNonQuery();

            _conn.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand Command = new SqlCommand("Delete from product  where Id =@id ", _conn);
            Command.Parameters.AddWithValue("@id", id);
            Command.ExecuteNonQuery();
            _conn.Close();
        }


        private void ConnectionControl()
        {
            if (_conn.State == System.Data.ConnectionState.Closed)
            {
                _conn.Open();
            }
        }

    }
    }

