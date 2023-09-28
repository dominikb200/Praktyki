using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karty478
{
    [Serializable]
    internal class Deck
    {
        private List<Card> cards;
        //private Random random = new();

        public Deck()
        {
            cards = new List<Card>();
            for(int suit = 0; suit <= 3; suit++)
            {
                for(int value = 1; value <= 13; value++)
                {
                    cards.Add(new Card((Suits)suit, (Values)value));
                }
            }
        }
        public Deck(IEnumerable<Card> initialcards)
        {
            cards = new List<Card>(initialcards);
        }
        public int Count { get { return cards.Count; } }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }
        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }
        /*public void Shuffle()
        {
            List<Card> NewCards = new List<Card>();
            while(cards.Count > 0)
            {
                int CardToMove = random.Next(cards.Count);
                NewCards.Add(cards[CardToMove]);
                cards.RemoveAt(CardToMove);
            }
            cards = NewCards;
        }*/

        public IEnumerable<string> GetCardNames()
        {
            string[] CardNames = new string[cards.Count];
            for(int i = 0; i < cards.Count; i++)
            {
                CardNames[i] = cards[i].Name;
            }
            return CardNames;
        }
        public void Sort()
        {
            cards.Sort(new CardComparer_bySuit());
        }
    }
}
