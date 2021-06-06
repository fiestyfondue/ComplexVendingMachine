using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexVendingMachine
{
    class DrinkMachine
    {
        const int COST_OF_DRINK = 150;
        public int RunningTotal { get; set; }

        public DrinkMachine()        //Constructors
        {
            RunningTotal = 0;
        }
        public void DepositCoin(int money)              //Method that do not return just check conditions
        {
            //the only valid entries are 5,10,20,50,100
            switch(money)
            {
                case (5):
                    RunningTotal += 5;
                    break;
                case (10):
                    RunningTotal += 10;
                    break;
                case (20):
                    RunningTotal += 20;
                    break;
                case (50):
                    RunningTotal += 50;
                    break;
                case (100):
                    RunningTotal += 100;
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }

        }

        public bool checkTotal()
        {
            if(RunningTotal>=COST_OF_DRINK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DisplayDrinkSelection()
        {

            Console.WriteLine("**************");
            Console.WriteLine("*  C-Coke    *");
            Console.WriteLine("*  P-Pepsi   *");
            Console.WriteLine("*  D-DietCoke*");
            Console.WriteLine("**************");
            Console.WriteLine();
            Console.WriteLine("Enter your Selection");
            MakeDrinkSelection(Convert.ToChar(Console.ReadLine().ToUpper()));
        }

        private void MakeDrinkSelection(char selection)
        {
            bool selectionOk = false;
            while(!selectionOk)
            {
                switch(selection)                     //Valid keys and results 
                {
                    case 'C':
                        Console.WriteLine("ThankYou For choosing Coke");
                        ReturnChange();
                        selectionOk = true;
                        break;
                    case 'P':
                        Console.WriteLine("Thankyou for choosing Pepsi");
                        selectionOk = true;
                        break;
                    case 'D':
                        Console.WriteLine("ThankYou for choosing DietCoke");
                        selectionOk = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection : Enter the selection again");
                        selection = Convert.ToChar(Console.ReadLine().ToUpper());
                        selectionOk = false;
                        break;

                }
            }
        }
        private void ReturnChange()
        {
            if(RunningTotal>COST_OF_DRINK)
            {
                Console.WriteLine("Your change is {0}", RunningTotal - COST_OF_DRINK);
            }
        }

    }
}
