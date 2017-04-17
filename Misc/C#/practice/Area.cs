using System;
class Area
{
	int Result;
	public static void AreaRec()
	{
		int Length, Breadth;

		Console.WriteLine("Enter The Length Of the Rectangle");
		Length=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the breadth of the Rectangle");
		Breadth=Convert.ToInt32(Console.ReadLine());
	
		Result=Length*Breadth;
		Console.WriteLine("The Area Of The Reactangle {0}",Result);
	}
	public static void AreaSqu()
	{
		int side;
		Console.WriteLine("Enter the Side Of The Square");
		side=Convert.ToInt32(Console.ReadLine());
		Result=side*side;
		Console.WriteLine("The ARea Squ is {0}", Result);
	}
	static void Main(string [] args)
	{
		int option;
		Console.WriteLine("Main Menu");
		Console.WriteLine("1.Area Of REactangle");
		Console.WriteLine("2.Area Of Squ");
	
		Console.WriteLine("Enter Ur Choice (1,2)");
		option=Convert.ToInt32(Console.ReadLine());
	
		switch(option)
		{
			case 1:
			AreaRec();
			break;
			
			case 2:
			AreaSqu();
			break;

			default:
			Console.WriteLine("Incorrect Choice");
			break;
		}
	}
}
