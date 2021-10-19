using System;
namespace SalesApp
{


    class SaleMenu
    {


        enum MenuOptions
        {
            //using enum to represent the menu
            CREATE, READ, DELETE, QUIT
        }



        public void PrintMenu()
        {
            Array values = Enum.GetValues(typeof(MenuOptions));

            foreach(var value in values)
            {
                Console.WriteLine(value);
            }
        }
    }









}
