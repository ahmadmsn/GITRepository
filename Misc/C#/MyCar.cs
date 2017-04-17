using System;
class Car
{
	string Engine;
	int No_wheels;
	public void AcceptDetails()
	{
		Console.WriteLine(" Enter The Details of Car");
		Console.WriteLine("\n Enter The Engine Model");
		Engine = Console.ReadLine();
		Console.WriteLine("\n Enter The number of wheels");
		No_wheels = Convert.ToInt32(Console.ReadLine());
	}
	public void Display()
	{
		Console.WriteLine("Engine Model Is:");
		Console.WriteLine(Engine);
		Console.WriteLine("\n Total Wheels are :");
		Console.WriteLine(No_wheels);
	}
}
class MyCar
{
	public static void Main(string [] args)
	{
		Car c1 = new Car();
		c1.AcceptDetails();
		c1.Display();
	}
}
		
		