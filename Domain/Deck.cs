using Snap_Test.Domain.Entities;
using Snap_Test.Domain.Enums;

namespace Snap_Test.Domain
{
    public class Deck
    {
        private readonly List<Card> _cards;
        private readonly Random _random = new();

        public Deck()
        {
            _cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    _cards.Add(new Card(suit, rank));
                }
            }
        }

        public void Shuffle()
        {
            _cards.Sort((a, b) => _random.Next(-1, 2));
        }

        public Card DrawCard()
        {
            if(_cards.Count == 0)
            {
                throw new InvalidOperationException("No cards left in the deck.");
            }
            var card = _cards[0];
            _cards.RemoveAt(0);
            return card;
        }
    }
}
