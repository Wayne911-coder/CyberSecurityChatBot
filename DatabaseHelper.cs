using MySql.Data.MySqlClient;
using System.Data;

public class DatabaseHelper
{
    private string connectionString =
        "server=127.0.0.1;port=3305;database=cybersecuritychatbot;uid=root;pwd=Sizwemdluli03!;";

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }
    public void AddTask(string title,
                    string description,
                    DateTime reminderDate)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();

            string query =
            @"INSERT INTO Tasks
        (Title, Description, ReminderDate)
        VALUES
        (@title,@description,@reminderDate)";

            MySqlCommand cmd =
                new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@reminderDate", reminderDate);

            cmd.ExecuteNonQuery();
        }
    }
    public DataTable GetTasks()
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();

            string query = "SELECT * FROM Tasks";

            MySqlDataAdapter adapter =
                new MySqlDataAdapter(query, conn);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
    }
    public void DeleteTask(int taskID)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();

            string query = "DELETE FROM Tasks WHERE TaskID = @taskID";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@taskID", taskID);

            cmd.ExecuteNonQuery();
        }
    }
        public void CompleteTask(int taskID)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();

            string query = "UPDATE Tasks SET IsCompleted = 1 WHERE TaskID = @taskID";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@taskID", taskID);

            cmd.ExecuteNonQuery();
        }
    }
}




