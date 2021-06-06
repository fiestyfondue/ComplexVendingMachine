using System;

namespace ComplexVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinkMachine drinkMachine = new DrinkMachine();
            
            while(!drinkMachine.checkTotal())
            {
                Console.WriteLine("Enter more coins or bills{5,10,20,50,100}");
                drinkMachine.DepositCoin(Convert.ToInt32(Console.ReadLine()));
            }
            drinkMachine.DisplayDrinkSelection();
            Console.ReadLine();
        }
    }
}
