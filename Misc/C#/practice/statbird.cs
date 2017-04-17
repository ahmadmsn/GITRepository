using System;
class statbird
{
	static int population=10;
	string color;
	public statbird()
	{
		population++;
		color = "brown";
	}
	public statbird(string s)
	{
		color=s;
		population++;
	}
	public  void show()
	{
		Console.WriteLine("Population = " +population);
		Console.WriteLine("Color =  " +color);
	}
	public static void showpopulation()
	{
		Console.WriteLine("Population = " +population);
	}
}
class demo
{
	public static void Main()
	{
		statbird b=new statbird();
		b.show();
		statbird b1=new statbird("Red");
		statbird b2=new statbird("Black");
		b2.show();
		statbird b3=new statbird();
		b.show();
		b1.show();
		b2.show();
		b3.show();
		//statbird.showpopulation();
	}
}
		
		
		