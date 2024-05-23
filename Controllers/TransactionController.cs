﻿using CloudDevelopment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.Data.SqlClient;

namespace CloudDev101.Controllers
{
    public class TransactionController : Controller
    {



        [HttpPost]
        public ActionResult PlaceOrder(int userID, int productID, int price)
        {
            try
            {
                var conString = Program.GetConnectionString();
                Console.WriteLine(userID);
                Console.WriteLine(productID);
                var con = new SqlConnection(conString);
                var sql =
                    "INSERT INTO Transactions (TransactionID, UserID, ProductID, TransactionDate, Quantity, TotalAmount) VALUES (@TransactionID, @UserID, @ProductID, @TransactionDate, @Quantity, @TotalAmount)";

                var cmd = new SqlCommand(sql, con);
                {
                    var random = new Random();
                    var randomNumber = random.Next(1, 1001);

                    cmd.Parameters.AddWithValue("@TransactionID", randomNumber);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@ProductID", productID);
                    cmd.Parameters.AddWithValue("@TotalAmount", price);
                    cmd.Parameters.AddWithValue("Quantity", 1);
                    cmd.Parameters.AddWithValue("@TransactionDate", DateTime.Now);

                    con.Open();

                    var rowsAffected = cmd.ExecuteNonQuery();

                    con.Close();

                    if (rowsAffected > 0)
                        return RedirectToAction("Orders", "Home");
                    return View("Orders");
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);
                return View("Error");
            }
        }
    }

}