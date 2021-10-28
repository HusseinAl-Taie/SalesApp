using System;
using System.Collections.Generic;
using System.Data;
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
            command.CommandText = $"INSERT INTO sale(saleName, productName) VALUES('{toCreate.Name}','{toCreate.ProductName}')"
                //, "+//$"'{toCreate.Quantity}')"
                                                                            ;

            command.ExecuteNonQuery();
            connection.Close();

            Sale sale = new Sale();
            sale.ID = (int)command.LastInsertedId;
            sale.Name = toCreate.Name;
            sale.ProductName = toCreate.ProductName;
            //sale.Quantity = toCreate.Quantity;


            return sale;
        }

        public IList<Sale> Read()
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM sale";

            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            IList<Sale> sales = SalesFromReader(reader);

            connection.Close();
            return sales;
        }

       
        public void Delete(int id)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM sale WHERE id={id}";

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            
        }

        public IList<Sale> SalesFromReader(MySqlDataReader reader)
        {
            IList<Sale> sales = new List<Sale>();
            while (reader.Read())
            {
                //iterate to read values from row
                string name = reader.GetFieldValue<string>("saleName");
                int id = reader.GetFieldValue<int>("id");

                Sale sale = new Sale() { ID = id, Name = name };
                sales.Add(sale);
            }
            return sales;
        }
    }
}