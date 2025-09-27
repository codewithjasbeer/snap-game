using Snap_Test.Application;
using Snap_Test.Domain.Interfaces;
using Snap_Test.Domain.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snap_Test.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snap! Card Game");
            Console.WriteLine("Select matching condition:");
            Console.WriteLine("1. Face value (e.g., 7 of Spades and 7 of Diamonds)");
            Console.WriteLine("2. Suit (e.g., 3 of Diamonds and 9 of Diamonds)");
            Console.WriteLine("3. Both (e.g., Q of Hearts and Q of Hearts)");
            var choice = Console.ReadLine();

            IMatchStrategy strategy = choice switch
            {
                "1" => new FaceMatchStrategy(),
                "2" => new SuitMatchStrategy(),
                "3" => new BothMatchStrategy(),
                _ => new FaceMatchStrategy() // Default to FaceMatchStrategy
            };

            var game = new Game(strategy);

            Console.WriteLine("Please Enter to Play a Round");
            while (true)
            {
                Console.ReadLine();
                game.PlayRound();
            }
        }
    }
}
