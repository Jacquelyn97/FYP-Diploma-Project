using MySql.Data.MySqlClient;

namespace Final
{
    internal class SQL_Database
    {
        // TODO: Replace with your own local MySQL credentials, or load from a config file / environment variable
        MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=YOUR_PASSWORD_HERE; database=myweb");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
