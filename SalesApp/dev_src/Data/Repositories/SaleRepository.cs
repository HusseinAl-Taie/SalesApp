using System;
using System.Collections.Generic;
using SalesApp.dev_src.Data.Model;
using SalesApp.dev_src.Data.Repositories;


namespace SalesApp.dev_src.Data.Repositories
{

    internal class SaleRepository : ICrdRepository<Sale, int>
    {
        private IList<Sale> sales;
        private static int counter = 0;

        public SaleRepository()
        {
            sales = new List<Sale>();
        }

        public Sale Create(Sale toCreate)
        {
            toCreate.ID = counter;
            counter++;
            sales.Add(toCreate);

            return toCreate;
        }

        public IList<Sale> Read()
        {
            return sales;
        }

        public void Delete(int id)
        {
            for (int i = 0; i < sales.Count; i++)
            {
                if (sales[i].ID == id)
                {
                    sales.RemoveAt(i);
                    break;
                }
            }
        }
    }
}