using System;
using SalesApp.dev_src.Controllers;
using SalesApp.dev_src.Data.Repositories;
using SalesApp.dev_src.Services;

namespace SalesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a sale menu giving it a sale constructor as defined

            SaleMenu saleMenu = new SaleMenu(
                new SaleController(
                    new SaleService(
                        new SaleRepository())));

            saleMenu.AppMenuLoop();
            saleMenu.InteractiveLoop();
        }
    }
}
