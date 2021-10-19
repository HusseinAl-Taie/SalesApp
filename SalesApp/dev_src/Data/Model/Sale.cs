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


        public override string ToString()
        {
            return $"Sale[ID ={ ID},  Name ={Name}]";
            
        }
    }
}