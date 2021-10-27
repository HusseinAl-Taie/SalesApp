using System;
using System.Collections.Generic;
using SalesApp.dev_src.Data.Model;

namespace SalesApp.dev_src.Data.Repositories
{

    internal class SaleRepository
    {
        private IList<Sale> sales;
        private static int counter = 0;

        //initilising the list
        public SaleRepository(){
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
            throw new NotImplementedException();
        }

        internal void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}