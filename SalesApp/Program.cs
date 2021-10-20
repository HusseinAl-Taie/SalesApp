using System;
using SalesApp.dev_src.Controllers;

namespace SalesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a sale menu giving it a sale constructor as defined
            SaleMenu menu = new SaleMenu(new SaleController());
           
            menu.AppMenuLoop();
           

            menu.InteractiveLoop();


        }
    }
}
