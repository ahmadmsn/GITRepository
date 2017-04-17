using System;
class leapyear
{
	public static void Main(string [] args)
	{
		int year;
		//int temp;
		Console.WriteLine("Check Year Is LEAP YEAR or NOT");
		Console.WriteLine("----------------------------------------------------");
		Console.WriteLine("Enter The Year:");
		year = Convert.ToInt32(Console.ReadLine());
		//for(temp=0; temp<10;temp++)
		{
			if((year % 4 == 0) && (year % 100 !=0 || year % 400 == 0))
			{
				Console.WriteLine("Year Is Leap Year : {0}", year);
			}
			else
			{
				Console.WriteLine(" Year Is not a Leap Year");
			}
		}
		Console.ReadLine();
	}
}