using System;
using MySql.Data.MySqlClient;

public class TaskManager
{
    private string connString = "server=localhost;database=chatbot;uid=root;pwd=YOUR_PASSWORD;";

    public string AddTask(string title, string description, DateTime? reminderDate)
    {
        try
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                string query = @"INSERT INTO Tasks (Title, Description, ReminderDate)
                                 VALUES (@title, @description, @reminderDate)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@description", description);

                    // Handle null reminder safely
                    if (reminderDate.HasValue)
                        cmd.Parameters.AddWithValue("@reminderDate", reminderDate.Value);
                    else
                        cmd.Parameters.AddWithValue("@reminderDate", DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }

            return "✅ Task added successfully!";
        }
        catch (Exception ex)
        {
            return "❌ Failed to add task: " + ex.Message;
        }
    }
}
