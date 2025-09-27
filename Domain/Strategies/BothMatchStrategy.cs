using Snap_Test.Domain.Entities;
using Snap_Test.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snap_Test.Domain.Strategies
{
    public class BothMatchStrategy : IMatchStrategy
    {
        public string RuleName => "Suit + Face Match";

        public bool IsMatch(Card card1, Card card2)
        {
         return card1.Suit == card2.Suit && card1.Rank == card2.Rank;
        }
    }
}
