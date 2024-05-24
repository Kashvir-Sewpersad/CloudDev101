/*using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace CloudDevelopment.Models
{
    public class LoginModel
    {
        public static string con_string = "Integrated Security=SSPI;Persist Security Info=False;User ID=\"\";Initial Catalog=test;Data Source=labVMH8OX\\SQLEXPRESS";


        public int SelectUser(string email, string name)
        {
            int userId = -1; // Default value if user is not found
            using (SqlConnection con = new SqlConnection(con_string))
            {
                string sql = "SELECT userID FROM userTable WHERE userEmail = @Email AND userName = @Name";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Name", name);
                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        userId = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception or handle it appropriately
                    // For now, rethrow the exception
                    throw ex;
                }
            }
            return userId;
        }

    }
}*/
using System.Data.SqlClient;

namespace CloudDevelopment.Models;

public class LoginModel
{
    private static readonly string ConString = "Server=tcp:clouddev-sql-server101.database.windows.net,1433;Initial Catalog=clod-sql-DB;Persist Security Info=False;User ID=Kashvir;Password=BrunoCorral1234#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

    public static int SelectUser(string email, string name)
    {
        var userId = -1; // Default value if user is not found
        using var con = new SqlConnection(ConString);
        const string sql = "SELECT userID FROM userTable WHERE userEmail = @userEmail AND userName = @userName";
        var cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("@userEmail", email);
        cmd.Parameters.AddWithValue("@userName", name);
        try
        {
            con.Open();
            var result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value) userId = Convert.ToInt32(result);
        }
        catch (Exception )
        {
            // Log the exception or handle it appropriately
            // For now, rethrow the exception
            throw ;
        }

        return userId;
    }
}
