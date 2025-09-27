using Snap_Test.Domain.Entities;
using Snap_Test.Domain.Interfaces;

namespace Snap_Test.Domain.Strategies
{
    public class SuitMatchStrategy : IMatchStrategy
    {
        public string RuleName => "Suit Match";

        public bool IsMatch(Card card1, Card card2)
        {
            return card1.Suit == card2.Suit;
        }
    }
}
