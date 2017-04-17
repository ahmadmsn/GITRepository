using System;
class outdemo
{
	static void add(int n, out int y)
	{
		y = n+n;
	}
	public static void Main()
	{
		int m;
		add (10, out m);
		Console.WriteLine(m);
	}
}
		