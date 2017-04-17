using System;
class factorialrec
{
	
	public int factr(int n)
	{
		int result;
		Console.WriteLine(n);
		if(n==1) return 1;
		result = factr(n-1)*n;
		return result;
	}
}
class demo
{
	public static void Main()
	{
		factorialrec f=new factorialrec();
		//Console.WriteLine(f.factr(3));
		Console.WriteLine(f.factr(4));
	}
}