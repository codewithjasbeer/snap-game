using Snap_Test.Domain;
using Snap_Test.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snap_Test.Application
{
    public class Game
    {
        private readonly Deck _deck;
        private readonly IMatchStrategy _matchStrategy;

        public Game(IMatchStrategy matchStrategy)
        {
            _deck = new Deck();
            _deck.Shuffle();
            _matchStrategy = matchStrategy;
        }

        public void PlayRound()
        {
            var card1 = _deck.DrawCard();
            var card2 = _deck.DrawCard();

            Console.WriteLine($"Card 1: {card1}");
            Console.WriteLine($"Card 2: {card2}");

            if (_matchStrategy.IsMatch(card1, card2))
            {
                Console.WriteLine($"Match found! Rule:  ({_matchStrategy.RuleName})");
            }
            else
            {
                Console.WriteLine($"No match.  Rule: ({_matchStrategy.RuleName})");
            }
        }
    }
}
