using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Avoda_Managerment.Models;
using Avoda_Managerment.Utils;

namespace Avoda_Managerment
{
    internal class Database
    {
        //private static readonly string conStr = "server=localhost;uid=root;pwd=root123;database=avoda_store";

        private static MySqlConnection cnn;

        private static Database myDB;

        private Database()
        {
            string conStr = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
            cnn = new MySqlConnection(conStr);
        }

        public static Database getInstance()
        {
            if (myDB == null)
            {
                myDB = new Database();
            }
            return myDB;
        }

        public DataTable getAllProductType()
        {
            openConnection(cnn);
            string sql = "SELECT DISTINCT(type) FROM product;";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            closeConnection(cnn);
            return table;
        }

        public DataTable getAvailableProduct()
        {
            openConnection(cnn);
            string sql = "SELECT * FROM product WHERE stock > 0";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            closeConnection(cnn);
            return table;
        }

        public DataTable getAllProduct()
        {
            openConnection(cnn);
            string sql = "SELECT * FROM product";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            closeConnection(cnn);
            return table;
        }

        public DataTable getProductById(int product_id)
        {
            openConnection(cnn);
            string sql = "SELECT * FROM product WHERE id = @id";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@id", product_id);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            closeConnection(cnn);
            return table;
        }

        public DataTable getAllCustomer()
        {
            openConnection(cnn);
            string sql = "SELECT * FROM customer";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            closeConnection(cnn);
            return table;
        }

        public DataTable getCustomerById(int customer_id)
        {
            openConnection(cnn);
            string sql = "SELECT * FROM customer WHERE id = @id";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@id", customer_id);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            closeConnection(cnn);
            return table;
        }

        public DataTable getCustomerByPhone(string phone)
        {
            openConnection(cnn);
            string sql = "SELECT * FROM customer WHERE phone = @phone";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@phone", phone);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            closeConnection(cnn);
            return table;
        }

        public DataTable getLastTransaction()
        {
            openConnection(cnn);
            string sql = "SELECT * FROM transactions ORDER BY id DESC LIMIT 1;";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            closeConnection(cnn);
            return table;
        }

        public DataTable getAllTransaction()
        {
            openConnection(cnn);
            string sql = "SELECT t.id, name, phone, total_price, score_use, final_price, score_earn, date " +
                "FROM transactions t, customer c " +
                "WHERE customer_id = c.id;";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            closeConnection(cnn);
            return table;
        }

        public DataTable getDetailTransaction(int transaction_id)
        {
            openConnection(cnn);
            string sql =
                "SELECT p.id, type, name, color, size, quantity, price " +
                "FROM transaction_detail td, product p " +
                "WHERE td.product_id = p.id " +
                "AND td.transaction_id = @id;;";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@id", transaction_id);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            closeConnection(cnn);
            return table;
        }

        public DataTable getProductTransaction(int product_id)
        {
            openConnection(cnn);
            string sql = "SELECT * FROM transaction_detail WHERE product_id = @id;";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@id", product_id);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            closeConnection(cnn);
            return table;
        }

        public bool updateStock(int product_id, int quantity)
        {
            DataTable currentProduct = getProductById(product_id);
            int currentStock = int.Parse(currentProduct.Rows[0]["stock"].ToString());
            int newStock = currentStock - quantity;

            string sql = "UPDATE product SET stock = @st WHERE id = @id";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@st", newStock);
            command.Parameters.AddWithValue("@id", product_id);

            openConnection(cnn);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cập nhật tồn kho lỗi!");
                return false;
            }
            finally
            {
                closeConnection(cnn);
            }
            return true;
        }

        public int updateCustomerScore(int score_use, long total_price, int customer_id)
        {
            DataTable currentCustomer = getCustomerById(customer_id);
            int currentScore = int.Parse(currentCustomer.Rows[0]["score"].ToString());
            currentScore -= score_use;
            int score_earn = int.Parse((total_price / Global.priceToScore).ToString());
            currentScore += score_earn;

            string sql = "UPDATE customer SET score = @score WHERE id = @id";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@id", customer_id);
            command.Parameters.AddWithValue("@score", currentScore);

            openConnection(cnn);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cập nhật điểm khách hàng lỗi!");
                return -1;
            }
            finally
            {
                closeConnection(cnn);
            }
            return score_earn;
        }

        public bool updateCustomer(Customer customer)
        {
            string sql = "UPDATE customer SET name = @name, phone = @phone WHERE id = @id";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@name", customer.Name);
            command.Parameters.AddWithValue("@phone", customer.Phone);
            command.Parameters.AddWithValue("@id", customer.Id);

            openConnection(cnn);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm khách hàng lỗi!");
                return false;
            }
            finally
            {
                closeConnection(cnn);
            }
            return true;
        }

        public bool addCustomer(Customer customer)
        {
            string sql = "INSERT INTO customer (name, phone, score) VALUES (@name, @phone, @score)";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@name", customer.Name);
            command.Parameters.AddWithValue("@phone", customer.Phone);
            command.Parameters.AddWithValue("@score", 0);

            openConnection(cnn);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm khách hàng lỗi!");
                return false;
            }
            finally
            {
                closeConnection(cnn);
            }
            return true;
        }

        public bool addTransaction(int customer_id, long total_price, int score_use, long final_price, int score_earn, DateTime date)
        {
            string sql = "INSERT INTO transactions VALUES (null, @id, @tprice, @score_use, @fprice, @score_earn, @date)";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@id", customer_id);
            command.Parameters.AddWithValue("@tprice", total_price);
            command.Parameters.AddWithValue("@score_use", score_use);
            command.Parameters.AddWithValue("@fprice", final_price);
            command.Parameters.AddWithValue("@score_earn", score_earn);
            command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd H:mm:ss"));

            openConnection(cnn);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm giao dịch lỗi!");
                return false;
            }
            finally
            {
                closeConnection(cnn);
            }
            return true;
        }

        public bool addDetailTransaction(int transaction_id, int product_id, int quantity)
        {
            string sql = "INSERT INTO transaction_detail (transaction_id, product_id, quantity) " +
                "VALUES (@trans_id, @cus_id, @quantity)";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@trans_id", transaction_id);
            command.Parameters.AddWithValue("@cus_id", product_id);
            command.Parameters.AddWithValue("@quantity", quantity);

            openConnection(cnn);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm chi tiết giao dịch lỗi!");
                return false;
            }
            finally
            {
                closeConnection(cnn);
            }
            return true;
        }

        public bool addProduct(Product product)
        {
            string sql = "INSERT INTO product VALUES (null, @type, @name, @color, @size, @stock, @price)";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@type", product.Type);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@color", product.Color);
            command.Parameters.AddWithValue("@size", product.Size);
            command.Parameters.AddWithValue("@stock", product.Stock);
            command.Parameters.AddWithValue("@price", product.Price);

            openConnection(cnn);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm sản phẩm lỗi!");
                return false;
            }
            finally
            {
                closeConnection(cnn);
            }
            return true;
        }

        public bool updateProduct(Product product)
        {
            string sql = "UPDATE product SET price = @price, stock = @stock WHERE id = @id";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@price", product.Price);
            command.Parameters.AddWithValue("@stock", product.Stock);
            command.Parameters.AddWithValue("@id", product.Id);

            openConnection(cnn);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lưu sản phẩm lỗi!");
                return false;
            }
            finally
            {
                closeConnection(cnn);
            }
            return true;
        }

        public bool deleteProductById(int product_id)
        {
            string sql = "DELETE FROM product WHERE id = @id";
            MySqlCommand command = new MySqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@id", product_id);

            openConnection(cnn);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xóa sản phẩm lỗi!");
                return false;
            }
            finally
            {
                closeConnection(cnn);
            }
            return true;
        }

        private void openConnection(MySqlConnection conn)
        {
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void closeConnection(MySqlConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}