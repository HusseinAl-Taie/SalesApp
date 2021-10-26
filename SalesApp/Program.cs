using System;
using SalesApp.dev_src.Controllers;
using SalesApp.dev_src.Services;

namespace SalesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SaleService service = new SaleService();
            SaleController controller = new SaleController(service);
            //creating a sale menu giving it a sale constructor as defined
            SaleMenu saleMenu = new SaleMenu(controller);

            saleMenu.AppMenuLoop();


            saleMenu.InteractiveLoop();


        }
    }
}
