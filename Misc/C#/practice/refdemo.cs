using System;
class refdemo
{
	public void add(int number)
	{
		number+=number;
		//return number;
		//Console.WriteLine(ref int number);
	}
	
}
class demo
{
	public static void Main()
	{
		int num=10;
		refdemo r=new refdemo();
		Console.WriteLine("beforecall "+ num);
		r.add(ref num);
		Console.WriteLine("after call "+num);
		
	}
}