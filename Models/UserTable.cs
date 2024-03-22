
//********************************** start of file **********************************//


using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace CloudDev101.Models
{
    public class UserTable : Controller
    {
        
        
        public static string con_string = "Server=tcp:clouddev-sql-server101.database.windows.net,1433;Initial Catalog=clod-sql-DB;Persist Security Info=False;User ID=Kashvir;Password=BrunoCorral1234#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        
        public static System.Data.SqlClient.SqlConnection con =  new System.Data.SqlClient.SqlConnection(con_string);

        public string Name { get; set; }

        public string ID{ get; set; }

        public IActionResult Index()
        {
            return View();
        }
    }
}
//************************************* end of file *****************************//