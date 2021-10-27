using System;
using MySql.Data.MySqlClient;
using SalesApp.dev_src.utils;

namespace SalesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a sale menu giving it a sale constructor as defined

            //SaleMenu saleMenu = new SaleMenu(
            //    new SaleController(
            //        new SaleService(
            //            new SaleRepository())));

            //saleMenu.AppMenuLoop();
            //saleMenu.InteractiveLoop();

            MySqlConnection connection = MySqlUtils.GetConnection();

            //opening the connection
            connection.Open();

            bool connectionOpen = connection.Ping();

            Console.WriteLine($@"Connection status:{ connection.State}
Ping Succesful: { connectionOpen}");

            //closing connection
            connection.Dispose();
        }
    }
}
