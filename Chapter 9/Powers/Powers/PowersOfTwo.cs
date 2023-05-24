using System.Collections;

class PowersOfTwo : IEnumerable<int>
{
	public IEnumerator<int> GetEnumerator()
	{
		double maxPower = Math.Round(Math.Log(int.MaxValue, 2));
		for (int i = 0; i < maxPower; i++)
		{
			yield return (int)Math.Pow(2, i);
		}
	}

	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}