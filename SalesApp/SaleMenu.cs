using System;
using SalesApp.dev_src.Controllers;

namespace SalesApp
{


    class SaleMenu
    {
        //sale controller initilised 
        private readonly SaleController saleController;

        //passing the controller through a class objct that must have salecontroller as parameter
        public SaleMenu(SaleController saleController)
        {
            this.saleController = saleController;
        }


        enum MenuOptions
        {
            //using enum to represent the menu
            CREATE, READ, DELETE, QUIT
        }

        public void PrintMenu()
        {
            Array values = Enum.GetValues(typeof(MenuOptions));
            Console.WriteLine("==== Menu ======");
                foreach (var value in values)
                {
                    Console.WriteLine(value);
                }
            Console.WriteLine("===== ===== ======");
        }

        //loop function 
        public void InteractiveLoop()
        {
            //creating a bool in as a loop breaker
            bool inMenu = true;
            // the loop will run as long as in menu true
            while (inMenu)
            {
                //clear screen
                Console.Clear();

                //show menu
                PrintMenu();

                //get input from user
                string input = Console.ReadLine();

                //convert input to enum menu options
                bool b = Enum.TryParse(input, true,out MenuOptions menuOptions);

                //valdiate the input 
                if (b == false)
                {
                    Console.WriteLine("Invalid input");
                    continue; 
                }

                //and choose option with input from menu Options
                switch (menuOptions)
                {
                    case MenuOptions.CREATE:
                        saleController.CREATE();
                        break;
                    case MenuOptions.READ:
                        saleController.READ();
                        break;
                    case MenuOptions.DELETE:
                        saleController.DELETE();
                        break;
                    case MenuOptions.QUIT:
                        inMenu = false;
                        break;

                }

            }

        }
    }









}
