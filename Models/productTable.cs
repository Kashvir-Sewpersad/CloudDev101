﻿/*using System.Data.SqlClient;

namespace CloudDevelopment.Models
{
    public class productTable
    {
        //public static string con_string = "Server=tcp:clouddev-sql-server.database.windows.net,1433;Initial Catalog=CLDVDatabase;Persist Security Info=False;User ID=Byron;Password=RockeyM12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public static string con_string = "Integrated Security=SSPI;Persist Security Info=False;User ID=\"\";Initial Catalog=test;Data Source=labVMH8OX\\SQLEXPRESS";

        public static SqlConnection con = new SqlConnection(con_string);

        public string Name { get; set; }

        public string Price { get; set; }

        public string Category { get; set; }

        public string Availability { get; set; }



        public int insert_product(productTable p)
        {

            try
            {
                string sql = "INSERT INTO productTable (productName, productPrice, productCategory, productAvailability) VALUES (@Name, @Price, @Category, @Availability)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", p.Name);
                cmd.Parameters.AddWithValue("@Price", p.Price);
                cmd.Parameters.AddWithValue("@Category", p.Category);
                cmd.Parameters.AddWithValue("@Availability", p.Availability);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
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
}*/ using System.Data.SqlClient;

namespace CloudDevelopment.Models;

public class ProductTable
{
    public static string ConString = "Server=tcp:clouddev-sql-server101.database.windows.net,1433;Initial Catalog=clod-sql-DB;Persist Security Info=False;User ID=Kashvir;Password=BrunoCorral1234#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

    public static SqlConnection Con = new(ConString);


    public int ProductID { get; set; }

    public string productName { get; set; }

    public string Category { get; set; }

    public decimal Price { get; set; }

    public int Availability { get; set; }


    public int insert_product(ProductTable p)
    {
        try
        {
            const string sql = "INSERT INTO productTable (productName, Price, Category, Availability, ProductID) VALUES (@productName, @Price, @Category, @Availability, @ProductID)";
            var cmd = new SqlCommand(sql, Con);
            var random = new Random();
            var randomNumber = random.Next(1, 1001);
            cmd.Parameters.AddWithValue(@"ProductID", randomNumber);
            cmd.Parameters.AddWithValue("@productName", p.productName);
            cmd.Parameters.AddWithValue("@Price", p.Price);
            cmd.Parameters.AddWithValue("@Category", p.Category);
            cmd.Parameters.AddWithValue("@Availability", p.Availability);
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


    // Method to retrieve all products from the database
    public static List<ProductTable> GetAllProducts()
    {
        var products = new List<ProductTable>();

        using var con = new SqlConnection(ConString);
        const string sql = "SELECT * FROM productTable";
        var cmd = new SqlCommand(sql, con);

        con.Open();
        var rdr = cmd.ExecuteReader();
        while (rdr.Read())
        {
            var product = new ProductTable
            {
                ProductID = Convert.ToInt32(rdr["ProductID"]),
                productName = rdr["ProductName"].ToString(),
                Price = Convert.ToInt32(rdr["Price"]),
                Category = rdr["Category"].ToString(),
                Availability = Convert.ToInt32(rdr["Availability"])
            };

            products.Add(product);
        }

        return products;
    }
}