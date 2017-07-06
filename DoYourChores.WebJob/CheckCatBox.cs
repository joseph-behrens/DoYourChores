using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoYourChores.WebJob
{
    class CheckCatBox
    {
        
        public static DateTime GetDeadline()
        {
            DateTime deadLine;
            // Create the connection to the resource!
            // This is the connection, that is established and
            // will be available throughout this block.
            using (SqlConnection conn = new SqlConnection())
            {
                // Create the connectionString
                conn.ConnectionString = "Server=tcp:doyourchoresjb.database.windows.net,1433;Initial Catalog=chores_db;Persist Security Info=False;User ID=jbsa;Password=Creature99!!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                conn.Open();

                // Create the command
                SqlCommand command = new SqlCommand("SELECT * FROM CatBoxes", conn);
                
                deadLine = ReadDeadline(command);
                
                conn.Close();
                conn.Dispose();

                return deadLine;
            }

            DateTime ReadDeadline(SqlCommand command)
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return (DateTime)reader["TimeToCleanAgain"];
                    }
                    return DateTime.UtcNow;
                }
            }


        }

        

        
    }
}
