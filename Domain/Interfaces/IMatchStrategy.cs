using Snap_Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snap_Test.Domain.Interfaces
{
    public interface IMatchStrategy
    {
        bool IsMatch(Card card1, Card card2);
        string RuleName { get; }
    }
}
