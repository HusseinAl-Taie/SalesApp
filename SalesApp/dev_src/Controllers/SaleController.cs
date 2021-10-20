using System;
using System.Collections.Generic;
using SalesApp.dev_src.Data.Model;

namespace SalesApp.dev_src.Controllers
{
    public class SaleController
    {
        //private readonly ItemService itemService;

        //counter for the ID count
        private static int counter = 0;
        private IList<Sale> sales;

        //a constructor to initislised the list
        public SaleController()
        {
            sales = new List<Sale>();
        }

        internal void CREATE()
        {
            Sale sale = new Sale();
            sale.ID = counter;
            sale.Name = "TestSale";

            //adding the sale item to the list
            sales.Add(sale);
            counter++;


        }

        internal void READ()
        {
            foreach (var sale in sales)
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
                //loop though the list of ids in sales list incrementally 
                for (int i=0;i< sales.Count; i++)
                {
                    // if the condition is met the sale will be removed
                    if (sales[i].ID == id)
                    {
                        sales.RemoveAt(i);
                        break;
                    }
                }
            }



        }
    }
}
