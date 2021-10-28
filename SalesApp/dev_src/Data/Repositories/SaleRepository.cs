using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SalesApp.dev_src.Data.Model;
using SalesApp.dev_src.Data.Repositories;


namespace SalesApp.dev_src.Data.Repositories
{

    internal class SaleRepository : ICrdRepository<Sale, int>
    {
        private readonly MySqlConnection connection;

        public SaleRepository(MySqlConnection mySqlConnection)
        {
            connection = mySqlConnection;
        }

        public Sale Create(Sale toCreate)
        {
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = $"INSERT INTO sale(saleName, productName, quantity ) VALUES('{toCreate.Name}', '{toCreate.ProductName}', '{toCreate.Quantity}')";

            command.ExecuteNonQuery();
            connection.Close();

            Sale sale = new Sale();
            sale.ID = (int)command.LastInsertedId;
            sale.Name = toCreate.Name;
            sale.ProductName = toCreate.ProductName;
            sale.Quantity = toCreate.Quantity;


            return sale;
        }

        public IList<Sale> Read()
        {
            return null;
        }

        public void Delete(int id)
        {
        }
    }
}