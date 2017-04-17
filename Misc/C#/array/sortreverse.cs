using System;
class sortreverse
{
	public static void Main()
	{
		int [] x={30,10,80,90,20};

		Console.WriteLine("Array Before Sorting");
		foreach(int i in x)
		{
			Console.Write(" "+i);
		}
		Console.WriteLine()	;
		Array.Sort(x);
		Console.WriteLine("Array After Sorting");
		foreach(int i in x)
		{
			Console.Write(" "+i);
		}
		Console.WriteLine();

		//int n=Array.GetLength(x);

		//int n1=Array.GetValue(x[0]);
		//Console.WriteLine("Length Of Array"+n1);
			
	}
}