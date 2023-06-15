using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CS322___Projekat
{
    class Database
    {
        private static string _connStr = "server=localhost;user=root;database=322projekat;port=3306;";

        public static void LoadRestorants(ref List<Restorant> restorants)
        {
            MySqlConnection conn = new MySqlConnection(_connStr);

            try
            {
                Console.WriteLine("Connecting...");
                conn.Open();
                Console.WriteLine("Successful Connection!");

                string sql = "SELECT * FROM restorant";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    restorants.Add(new Restorant(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3)));
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
        }
        
        public static void AddRestorant(Restorant restorant)
        {
            MySqlConnection conn = new MySqlConnection(_connStr);

            try
            {
                Console.WriteLine("Connecting...");
                conn.Open();
                Console.WriteLine("Successful Connection!");

                string sql = $"INSERT INTO restorant (restorantId, name, foodType, photoDir) " +
                             $"VALUES (NULL, '{restorant.Name}', '{restorant.FoodType}', '{restorant.PhotoDir}');";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
        }
        public static void DeleteRestorant(Restorant restorant)
        {
            MySqlConnection conn = new MySqlConnection(_connStr);

            try
            {
                Console.WriteLine("Connecting...");
                conn.Open();
                Console.WriteLine("Successful Connection!");

                string sql = $"DELETE FROM restorant WHERE restorant.restorantId = " + restorant.RestorantId.ToString();
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
        }
        public static void EditRestorant(Restorant restorant)
        {
            MySqlConnection conn = new MySqlConnection(_connStr);

            try
            {
                Console.WriteLine("Connecting...");
                conn.Open();
                Console.WriteLine("Successful Connection!");

                string sql = $"UPDATE restorant " +
                             $"SET name = '{restorant.Name}', foodType = '{restorant.FoodType}', photoDir = '{restorant.PhotoDir}' " +
                             $"WHERE restorant.restorantId = {restorant.RestorantId}";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
        }
        public static void AddFoodItem(FoodItem food)
        {
            MySqlConnection conn = new MySqlConnection(_connStr);

            try
            {
                Console.WriteLine("Connecting...");
                conn.Open();
                Console.WriteLine("Successful Connection!");

                string sql = $"INSERT INTO fooditem (foodId, restorantId, price, name, description, type, photodir) " +
                             $"VALUES (NULL, '{food.RestorantId}', '{food.Price}', '{food.Name}', '{food.Description}', '{food.Type}', '{food.PhotoDir}');";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
        }
        public static void LoadMenu(ref List<FoodItem> foodMenu, Restorant selectedRestorant)
        {
            MySqlConnection conn = new MySqlConnection(_connStr);

            try
            {
                Console.WriteLine("Connecting...");
                conn.Open();
                Console.WriteLine("Successful Connection!");

                string sql = "SELECT * FROM `fooditem` WHERE `restorantId` = " + selectedRestorant.RestorantId.ToString();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    foodMenu.Add(new FoodItem(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetInt32(2),
                                              rdr.GetString(3), rdr.GetString(4), rdr.GetString(5), rdr.GetString(6)));
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
        }
        public static void UserRegistration(User user)
        {
            MySqlConnection conn = new MySqlConnection(_connStr);

            try
            {
                Console.WriteLine("Connecting...");
                conn.Open();
                Console.WriteLine("Successful Connection!");

                string sql = $"INSERT INTO `user` (`userId`, `username`, `password`, `email`, `creationDate`) " +
                             $"VALUES (NULL, '{user.Username}', '{user.Password}', '{user.Email}', '{user.CreationDate}');";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
        }
        public static void LoadUsers(ref List<User> users)
        {
            MySqlConnection conn = new MySqlConnection(_connStr);

            try
            {
                Console.WriteLine("Connecting...");
                conn.Open();
                Console.WriteLine("Successful Connection!");

                string sql = "SELECT * FROM user";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    users.Add(new User(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), 
                                        rdr.GetDateTime(4).ToString("yyyy-MM-dd HH:mm:ss")));
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
        }
        public static void AddOrder(Order order)
        {
            MySqlConnection conn = new MySqlConnection(_connStr);

            try
            {
                Console.WriteLine("Connecting...");
                conn.Open();
                Console.WriteLine("Successful Connection!");

                string sql = $"INSERT INTO `order` (`orderId`, `userId`, `restorantName`, `price`, `time`) " +
                             $"VALUES (NULL, '{order.UserId}', '{order.RestorantName}', '{order.Price}', '{order.Time}');";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
        }
        public static void SearchRestorants(/*ref List<Restorant> restorants,*/ string text)
        {
            string query = "SELECT * FROM restorant WHERE name LIKE '" + text + "%' ;";

            MySqlConnection conn = new MySqlConnection(_connStr);

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", text.Trim());

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                Console.WriteLine(cmd.ToString());
                Console.WriteLine(cmd);
             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
        }
        public static void LoadOrders(ref List<Order> orders, User user)
        {
            MySqlConnection conn = new MySqlConnection(_connStr);

            try
            {
                Console.WriteLine("Connecting...");
                conn.Open();
                Console.WriteLine("Successful Connection!");

                string sql = "SELECT * FROM `order` WHERE `userId` = " + user.UserId;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    orders.Add(new Order(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetString(2), rdr.GetInt32(3),
                                        rdr.GetDateTime(4).ToString("yyyy-MM-dd HH:mm:ss")));
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
        }

    }
}
