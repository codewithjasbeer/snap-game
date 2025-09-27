using Snap_Test.Domain.Entities;
using Snap_Test.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snap_Test.Domain.Strategies
{
    public class FaceMatchStrategy : IMatchStrategy
    {
        public string RuleName => "Face Match";
        public bool IsMatch(Card card1, Card card2)
        {
           return card1.Rank == card2.Rank;
        }
    }
}
