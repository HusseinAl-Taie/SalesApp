using System;
using System.Collections.Generic;
using SalesApp.dev_src.Data.Model;

namespace SalesApp.dev_src.Services
{
    public class SaleService
    {
        private IList<Sale> sales;
        private static int counter = 0;

        //const to init the list above
        public SaleService()
        {
            sales = new List<Sale>();
        }


        internal Sale Create(Sale toCreate)
        {
            toCreate.ID = counter;
            counter++;
            sales.Add(toCreate);
            return toCreate;
        }

        internal IEnumerable<Sale> Read()
        {
            return sales;

        }

        internal void Delete(int id)
        {

            //loop though the list of ids in sales list incrementally 
            for (int i = 0; i < sales.Count; i++)
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
