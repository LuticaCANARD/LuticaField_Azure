using MySql.Data.MySqlClient;
namespace SQLs
{
   public class SQLAPILu
    {

        public async Task SQLexecute(string qurey)
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = Sqlclass.Server,
                Database = Sqlclass.Database,
                UserID = Sqlclass.UserID,
                Password = Sqlclass.Password,
                SslMode = MySqlSslMode.Required
            };

            try
            {
                MySqlConnection conn=new MySqlConnection(builder.ConnectionString);
                await conn.OpenAsync();
                using (var command = conn.CreateCommand()) 
                {
                    command.CommandText = qurey;
                    command.CommandText = "DELETE FROM inventory WHERE name = @name;";
                    command.Parameters.AddWithValue("@name", "orange");

                    int rowCount = await command.ExecuteNonQueryAsync();
                    Console.WriteLine(String.Format("Number of rows deleted={0}", rowCount));
                }
              
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                
            }
        }
    }
}
