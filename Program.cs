using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stock sellin' time!");
            Console.WriteLine();
            
            var money = 100m;
            var stock = 0m;

            // *** Initializing a player ***
            // We start out in the uninitialized state
            var player = new Player();

            // Lets initialize a player 
            player.Start(money, stock);
            Console.WriteLine();

            // Lets try that again
            player.Start(money, stock);
            Console.WriteLine();
            // Looks like that didn't work. Lets try buying! 

            // *** Buying! ***

            // Let buy $50 worth
            player.Buy(10, 5);
            Console.WriteLine();
            
            // We now have money and stock! Lets try buying more! 
            player.Buy(10, 5);
            Console.WriteLine();
            
            // We now have no money, but we have stock. Let's try to buy more to make sure!
            player.Buy(100, 50);
            Console.WriteLine();

            // That didn't work--time to sell I guess!

            // *** Selling ***

            // Let's give selling a shot 
            player.Sell(5, 6);
            Console.WriteLine();

            // We now have money AND stock again! Let's sell the rest of it.
            player.Sell(20, 13);
            Console.WriteLine();

            // We now have money and no stock. Let's try selling stock just in case...
            player.Sell(500, 20);
            Console.WriteLine();

            // Nope, that doesn't work either!

            // Hope this helps you guys get a feel for how the state pattern 
            // could work in your game to make rules around state transition 
            // easier to think about!
        }
    }
}
