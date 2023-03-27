using Npgsql;

namespace Note_Version_2
{

    public sealed class DatabaseConnection
    {
        private static readonly DatabaseConnection instance = new DatabaseConnection();
        private readonly string connectionString = "Server=localhost;Port=5432;Username=postgres;Password=123;Database=note_khnom";
        private NpgsqlConnection connection;

        static DatabaseConnection() { }

        private DatabaseConnection() { }

        public static DatabaseConnection Instance
        {
            get
            {
                return instance;
            }
        }

        public NpgsqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new NpgsqlConnection(connectionString);
                connection.Open();
            }
            else if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }
    }

}
