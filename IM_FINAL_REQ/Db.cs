using MySql.Data.MySqlClient;

namespace IM_FINAL_REQ
{
    public static class Db
    {
        private const string ConnString = "Server=localhost;Port=3306;Database=registrar_queue;Uid=root;Pwd=;";

        public static MySqlConnection Open()
        {
            var conn = new MySqlConnection(ConnString);
            conn.Open();
            return conn;
        }
    }
}