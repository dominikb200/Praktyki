using karty389;

namespace dwieTalie418
{
    public partial class Form1 : Form
    {
        Deck deck1;
        Deck textBox2;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void ResetDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                int numberOfCards = random.Next(1, 11);
                deck1 = new Deck(new Card[] { });
                for (int i = 0; i < numberOfCards; i++)
                {
                    deck1.Add(new karty389.Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
                }
                deck1.Sort();
            }
            else
                deck2 = new Deck();
        }
    }
}