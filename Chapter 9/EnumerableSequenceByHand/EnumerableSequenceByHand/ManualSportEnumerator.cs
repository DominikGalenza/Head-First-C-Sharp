class ManualSportEnumerator : IEnumerator<Sport>
{
	public Sport Current
	{
		get
		{
			return (Sport)current;
		}
	}

	private int current = -1;

	object System.Collections.IEnumerator.Current
	{
		get
		{
			return current;
		}
	}

	public bool MoveNext()
	{
		int maxEnumValue = Enum.GetValues(typeof(Sport)).Length;
		if (current >= maxEnumValue - 1)
		{
			return false;
		}
		current++;
		return true;
	}
	
	public void Reset()
	{
		current = 0;
	}

	public void Dispose()
	{
		return;
	}
}