using System;
class paramexample
{
	public int addingarray_element(params int [] list)
	{
		int total=0;
		foreach(int i in list)
		{
			total+=i;
		}
		return total;
	}
}
class tester
{
	static void Main()
	{
		paramexample p=new paramexample();
		int tot=p.addingarray_element(1,2,3,4,5,6,7);
		Console.WriteLine("The Result is {0}",tot);
	}
}

