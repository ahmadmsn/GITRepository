using System;
class methodoverload
{
	/*public methodoverload()
	{
		int a=add(2,8);
		Console.WriteLine(a);
	}*/
	public int add(int a, int b)
	{
		return a+b;
	}
	public double add(double a, double b)
	{
		return a+b;
	}
	public int add(int a,int b,int c)
	{
		return a+b+c;
	}
	
}
class overloaddemo
{
	public static void Main()
	{
		methodoverload m1=new methodoverload();
		methodoverload m2=new methodoverload();
		methodoverload m3=new methodoverload();
		int i=m1.add(2,2);
		Console.WriteLine(i);
		double j=m2.add(2.0,2.5);
		Console.WriteLine(j);
		int k=m3.add(3,3,3);
		Console.WriteLine(k);
	}
	
}
		