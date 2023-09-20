public class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.WriteLine("Pięć losowych kart: ");
        List<Card> cards = new List<Card>();
        for (int i = 0; i < 5; i++)
        {
            cards.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
            Console.WriteLine(cards[i].Name);
        }
        Console.WriteLine();
        Console.WriteLine("Te same karty posortowane: ");
        cards.Sort(new CardComparer_byValue());
        foreach (Card card in cards) Console.WriteLine(card.Name);
        Console.ReadKey();
    }

}
enum Suits
{
    Spades,
    Clubs,
    Diamonds,
    Hearts
}
enum Values
{
    Ace = 1,
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10,
    Jack = 11,
    Queen = 12,
    King = 13
}
internal class Card
{
    public Suits Suit { get; set; }
    public Values Value { get; set; }
    public Card(Suits suit, Values value)
    {
        this.Suit = suit;
        this.Value = value;
    }
    public string Name
    {
        get
        {
            return Value.ToString() + " of " + Suit.ToString();
        }
    }
}
internal class CardComparer_byValue : IComparer<Card>
{
    public int Compare(Card x, Card y)
    {
        if(x.Value < y.Value) return -1;
        if(x.Value > y.Value) return 1;
        if(x.Suit < y.Suit) return -1;
        if(x.Suit > y.Suit) return 1;
        return 0;
    }
}
