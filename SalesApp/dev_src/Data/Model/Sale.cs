using System;
namespace SalesApp.dev_src.Data.Model
{
    public class Sale
    {
        //public Sale()
        //{
        //}

        public int ID { get; set; }
        public string Name { get; set; }
        public string ProductName { get; set; }
        //public int Quantity;
        //public int Price;
        //public DateTime SaleDate;


        public override string ToString()
        {
            return $"Sale[ID ={ID}, Sale Name = { Name} | Product Name ={ProductName}";//, Quantity= {Quantity}]"
            
            
        }
    }
} 