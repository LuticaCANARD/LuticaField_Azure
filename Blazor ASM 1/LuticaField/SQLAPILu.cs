using MySql.Data.MySqlClient;
namespace Blazor_ASM_1
{
    public class SQLAPILu
    {
        protected internal string Server="lusever.mysql.database.azure.com";
        protected internal string UserID = "User";
        protected internal string Password="{your_password}";
        protected internal string Database="{your_database}";
        protected internal MySqlSslMode SslMode =MySqlSslMode.Required;
        protected internal string SslCa="{path_to_CA_cert}";

        public int SQLexecute(string qurey)
        {
            string Serverlogin = "Server:" + Server + ";uid=" + UserID + ";Pwd=" + Password + ";database=" + Database;

            try
            {
                MySqlConnection conn=new MySqlConnection(Serverlogin);
                MySqlCommand cmd=conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = qurey;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                
            }
        }
    }
}
