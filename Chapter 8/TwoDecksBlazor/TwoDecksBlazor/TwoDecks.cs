namespace TwoDecksBlazor
{
	class TwoDecks
	{
		public int LeftDeckCount 
		{
			get
			{
				return leftDeck.Count;
			}
		}
		public int RightDeckCount 
		{ 
			get
			{
				return rightDeck.Count;
			}
		}
		public int LeftCardSelected { get; set; }
		public int RightCardSelected { get; set; }

		private Deck leftDeck = new Deck();
		private Deck rightDeck = new Deck();

		public string LeftDeckCardName(int i)
		{
			return leftDeck[i].ToString();
		}

		public string RightDeckCardName(int i)
		{
			return rightDeck[i].ToString();
		}

		public void Shuffle()
		{
			leftDeck.Shuffle();
		}

		public void Reset()
		{
			leftDeck = new Deck();
		}

		public void Sort()
		{
			rightDeck.Sort(new CardComparerByValue());
		}

		public void Clear()
		{
			rightDeck.Clear();
		}

		public void MoveCard(Direction direction)
		{
			if (direction == Direction.LeftToRight)
			{
				rightDeck.Add(leftDeck[LeftCardSelected]);
				leftDeck.RemoveAt(LeftCardSelected);
			}
			else
			{
				leftDeck.Add(rightDeck[RightCardSelected]);
				rightDeck.RemoveAt(RightCardSelected);
			}
		}
	}
}
