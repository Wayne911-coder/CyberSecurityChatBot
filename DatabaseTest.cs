using System;
using MySql.Data.MySqlClient;

namespace CyberSecurityBot
{
    public class DatabaseTest
    {
        public void TestConnection()
        {
            string connString = "server=localhost;database=chatbot;uid=root;pwd=Sizwemdluli03!;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    Console.WriteLine("Database Connected Successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection failed: " + ex.Message);
            }
        }
    }
}