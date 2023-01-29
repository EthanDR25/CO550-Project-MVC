using C0550_Project_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using SqlDataReader = Microsoft.Data.SqlClient.SqlDataReader;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;
using CO550_Project_Razor.Models;
using Microsoft.EntityFrameworkCore;

namespace C0550_Project_MVC.Controllers
{
    public class HomeController : Controller
    {

        //SqlCommand com = new SqlCommand();

        //SqlDataReader dr;

        //SqlConnection con = new SqlConnection();

        //List<DatabaseConnection> connections = new List<DatabaseConnection>();


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //con.ConnectionString = C0550_Project_MVC.Properties.Resources.ConnectionString;

        }

        public IActionResult Index()
        {
            //FetchMovieData();
            return View();
        }

        //private void FetchMovieData()
        //{
        //    if(connections.Count > 0)
        //    {
        //        connections.Clear();
        //    }

        //    try
        //    {
        //        con.Open();
        //        com.Connection = con;
        //        com.CommandText = "SELECT TOP (1000) [FilmID]\r\n      ,[Title]\r\n      ,[ReleaseDate]\r\n      ,[Duration]\r\n      ,[Price]\r\n      ,[Genre]\r\n      ,[Director]\r\n  FROM [aspnet-C0550_Project_MVC-A9A37BF3-47EF-4C23-83A7-24BDFF23D620].[dbo].[Film]";
                
        //        dr = com.ExecuteReader();

        //        while(dr.Read())
        //        {
        //            connections.Add(new DatabaseConnection()
        //            {
        //                FilmID = dr["FilmID"].ToString(),
        //                Title = dr["Title"].ToString(),
        //                ReleaseDate = dr["ReleaseDate"].ToString(),
        //                Duration = dr["Duration"].ToString(),
        //                Director = dr["Director"].ToString(),
        //                Genre = dr["Genre"].ToString(),
        //                Price = dr["Price"].ToString()
        //            });
        //        }
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
 
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Bookings()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}