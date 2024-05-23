



/*

using System.Data.SqlClient;

namespace CloudDevelopment.Models
{
    public class UserTable
    {

        public static string con_string = "Server=tcp:clouddev-sql-server101.database.windows.net,1433;Initial Catalog=clod-sql-DB;Persist Security Info=False;User ID=Kashvir;Password=BrunoCorral1234#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

      



        public static SqlConnection con = new SqlConnection(con_string);


       
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public int insertUser(UserTable m)
        {
            string sql = "INSERT INTO userTable (userName, userSurname, userEmail) VALUES (@Name, @Surname, @Email);";
            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                cmd.Parameters.AddWithValue("@Name", m.Name);
                cmd.Parameters.AddWithValue("@Surname", m.Surname);
                cmd.Parameters.AddWithValue("@Email", m.Email);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return rowsAffected;

            }
            catch (Exception )
            {

                throw ;
            }
        }

    }
}
*/

using System.Data.SqlClient;

namespace CloudDevelopment.Models;

public class UserTable
{
    public static string ConString = "Server=tcp:clouddev-sql-server101.database.windows.net,1433;Initial Catalog=clod-sql-DB;Persist Security Info=False;User ID=Kashvir;Password=BrunoCorral1234#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    public static SqlConnection Con = new(ConString);


    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }


    public int insert_User(UserTable m)
    {
        try
        {
            const string sql = "INSERT INTO Users (UserID, FirstName, LastName, Email) VALUES (@UserID, @FirstName, @LastName, @Email)";
            var cmd = new SqlCommand(sql, Con);
            var random = new Random();
            var randomNumber = random.Next(1, 1001);
            cmd.Parameters.AddWithValue("@UserID", randomNumber);
            cmd.Parameters.AddWithValue("@FirstName", m.FirstName);
            cmd.Parameters.AddWithValue("@LastName", m.LastName);
            cmd.Parameters.AddWithValue("@Email", m.Email);
            Con.Open();
            var rowsAffected = cmd.ExecuteNonQuery();
            Con.Close();
            return rowsAffected;
        }
        catch (Exception ex)
        {
            // Log the exception or handle it appropriately
            // For now, rethrow the exception
            throw ex;
        }
    }
}