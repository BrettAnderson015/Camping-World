using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CampingWorld
{
    public class Item
    {
        private const string SERVER = "127.0.0.1";
        private const string DATABASE = "brett";
        private const string UID = "root";
        private const string PASSWORD = "Letsdothis5!";
        private static MySqlConnection dbConn;

        public static void InitializeDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            string connString = builder.ToString();
            dbConn = new MySqlConnection(connString);
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public DateTime DateAcquired { get; set; }
        public int Quantity { get; set; }

        public Item(int id, string name, string description, decimal cost, DateTime dateAcquired, int quantity)
        {
            ID = id;
            Name = name;
            Description = description;
            Cost = cost;
            DateAcquired = dateAcquired;
            Quantity = quantity;
        }

        public Item() { }

        public static List<Item> GetItems()
        {
            List<Item> items = new List<Item>();
            string query = "Select * from cwinventory";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            int id;
            string name;
            string description;
            decimal cost;
            DateTime dateAcquired;
            int quantity;

            while (reader.Read())
            {
                id = (int)reader["ID"];
                name = reader["Name"].ToString();
                description = reader["Description"].ToString();
                cost = (decimal)reader["Cost"];
                dateAcquired = DateTime.Parse(reader["DateAcquired"].ToString());
                quantity = (int)reader["Quantity"];
                Item i = new Item(id, name, description, cost, dateAcquired, quantity);
                items.Add(i);
            }
            dbConn.Close();
            return items;
        }

        public static List<Item> GetSalesItems()
        {
            List<Item> items = new List<Item>();
            string query = "Select * from cwsales";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            int id;
            string name;
            string description;
            decimal cost;
            DateTime dateSold;
            int quantity;

            while (reader.Read())
            {
                id = (int)reader["ID"];
                name = reader["Name"].ToString();
                description = reader["Description"].ToString();
                cost = (decimal)reader["Cost"];
                dateSold = DateTime.Parse(reader["DateSold"].ToString());
                quantity = (int)reader["Quantity"];
                Item i = new Item(id, name, description, cost, dateSold, quantity);
                items.Add(i);
            }
            dbConn.Close();
            return items;
        }

        public static List<Item> GetItemByName(string searchname)
        {
            List<Item> searchitems = new List<Item>();
            string query = string.Format($"Select * from cwinventory where name = '{searchname}'");
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            int id;
            string name;
            string description;
            decimal cost;
            DateTime dateAcquired;
            int quantity;

            while (reader.Read())
            {
                id = (int)reader["ID"];
                name = reader["Name"].ToString();
                description = reader["Description"].ToString();
                cost = (decimal)reader["Cost"];
                dateAcquired = DateTime.Parse(reader["DateAcquired"].ToString());
                quantity = (int)reader["Quantity"];
                Item i = new Item(id, name, description, cost, dateAcquired, quantity);
                searchitems.Add(i);
            }
            dbConn.Close();
            return searchitems;
        }

        public static Item GetSingleItem(int searchid)
        {
            string query = string.Format($"Select * from cwinventory where id = '{searchid}';");
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            Item singleItem = new Item();
            int id;
            string name;
            string description;
            decimal cost;
            DateTime dateAcquired;
            int quantity;

            while (reader.Read())
            {
                id = (int)reader["ID"];
                name = reader["Name"].ToString();
                description = reader["Description"].ToString();
                cost = (decimal)reader["Cost"];
                dateAcquired = DateTime.Parse(reader["DateAcquired"].ToString());
                quantity = (int)reader["Quantity"];
                singleItem = new Item(id, name, description, cost, dateAcquired, quantity);
            }
            
            dbConn.Close();
            return singleItem;
        }

        public static Item Insert(int id, string name, string description, decimal cost, DateTime dateAcquired, int quantity)
        {
            string query = string.Format("INSERT INTO cwinventory(ID, Name, Description, Cost, DateAcquired, Quantity) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')"
                , id, name, description, cost, dateAcquired.ToString("yyyy-MM-dd"), quantity);
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            cmd.ExecuteNonQuery();

            Item item = new Item(id, name, description, cost, dateAcquired, quantity);
            dbConn.Close();
            return item;
        }

        public static Item InsertIntoSales(int id, string name, string description, decimal cost, DateTime dateAcquired, int quantity)
        {
            string query = string.Format("INSERT INTO cwsales(ID, Name, Description, Cost, DateSold, Quantity) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')"
                , id, name, description, cost, dateAcquired.ToString("yyyy-MM-dd"), quantity);
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            cmd.ExecuteNonQuery();

            Item item = new Item(id, name, description, cost, dateAcquired, quantity);
            dbConn.Close();
            return item;
        }

        public void Remove(int id)
        {
            string query = string.Format("DELETE FROM cwinventory WHERE ID='{0}'", id);
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }

        public void Change(int id, string name, string description, decimal cost, DateTime dateAcquired, int quantity)
        {
            string query = string.Format($"UPDATE cwinventory SET Name = '{name}', Description = '{description}', Cost = '{cost}', " +
                $"DateAcquired = '{dateAcquired.ToString("yyyy-MM-dd")}', Quantity = '{quantity}' WHERE ID = '{id}'");
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }

        public int SearchForID(int id)
        {
            string query = string.Format($"select count(ID) from cwinventory where ID = '{id}';");
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            int searchidexist = Convert.ToInt32(cmd.ExecuteScalar());
            dbConn.Close();
            return searchidexist;
        }

    }
}
