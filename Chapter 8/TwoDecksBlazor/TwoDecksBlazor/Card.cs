namespace TwoDecksBlazor
{
    class Card
    {
        public Values Value { get; private set; }
        public Suits Suit { get; private set; }
        public string Name
        {
            get
            {
                return $"{Value} of {Suit}";
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public Card(Values value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }
    }
}