using System;
using System.Collections.Generic;
using SalesApp.dev_src.Data.Model;
using SalesApp.dev_src.Services;

namespace SalesApp.dev_src.Controllers
{
    class SaleController
    {
        // service var
        private readonly SaleService saleService;

        //a constructor to initislised the list
        public SaleController(SaleService saleService)
        {
            this.saleService = saleService;
        }

        internal void CREATE()
        {
            Console.WriteLine("Insert Sale Name");
            Console.Write(">");
            string  saleName = Console.ReadLine();

            Sale toCreate = new Sale() { Name = saleName };

            Console.WriteLine("Insert Product Name");
            Console.Write(">");
            string productName = Console.ReadLine();

            Console.WriteLine("Insert Quantity");
            Console.Write(">");
            var quantity = Convert.ToInt32(Console.ReadLine());


            Sale newSale = saleService.Create(toCreate);

            Console.WriteLine($"New Sale Added: {newSale}{productName}{quantity}");
            Console.WriteLine("Press any key!");
            Console.ReadKey();
        }

        internal void READ()
        {
            IEnumerable<Sale> saleInDb = saleService.Read();

            foreach (var sale in saleInDb)
            {
                Console.WriteLine(sale);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        internal void DELETE()
        {
            Console.WriteLine("Please insert ID");
            Console.Write(">");
            string input =  Console.ReadLine();
            //create a bool to parse the input and output an ID
            bool b = int.TryParse(input, out int id);

            if (b)
            {
                saleService.Delete(id);
            }

        }
    }
}
