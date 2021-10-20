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

        enum AppMenuOptions
        {
            //using enum to represent the menu
            DATAENTRY, REPORTS
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

        public void PrintAppMenu()
        {
            Array values = Enum.GetValues(typeof(AppMenuOptions));
            Console.WriteLine("====App Menu ======");
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
                    default:
                        break;

                }

            }

        }

        public void AppMenuLoop()
        {
            bool inAppMenu = true;
            while (inAppMenu)
            {
                Console.Clear();
                PrintAppMenu();
                string input = Console.ReadLine();

                bool b = Enum.TryParse(input, true, out AppMenuOptions appMenuOptions);

                if (b == false)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                switch (appMenuOptions)
                {
                    case AppMenuOptions.DATAENTRY:
                        inAppMenu = false;
                        break;
                 
                    case AppMenuOptions.REPORTS:
                        break;

                    default:
                        break;
                }
            }

        }
    }









}
