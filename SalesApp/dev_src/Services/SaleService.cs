using System;
using System.Collections.Generic;
using SalesApp.dev_src.Data.Model;
using SalesApp.dev_src.Data.Repositories;

namespace SalesApp.dev_src.Services
{
    class SaleService
    {
        //sale repo declaration 
        private readonly SaleRepository saleRepository;

        //const to init the list above
        public SaleService(SaleRepository saleRepository)
        {
            this.saleRepository = saleRepository;
        }


        internal Sale Create(Sale toCreate)
        {

            Sale newSale = saleRepository.Create(toCreate);
            return newSale;
        }

        internal IEnumerable<Sale> Read()
        {
            return saleRepository.Read();
        }

        internal void Delete(int id)
        {
            saleRepository.Delete(id);

        }
    }
}
