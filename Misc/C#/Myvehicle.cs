using System;
class Vehicle
{
	public int number_of_tyres;
}
class Myvehicle
{
	static void Main(string [] args)
	{
		Vehicle car = new Vehicle();
		Vehicle motorcycle = new Vehicle();
		Console.WriteLine("Enter the number of tyres of car");
		car.number_of_tyres = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the number of tyres of motorcycle");
		motorcycle.number_of_tyres = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("\n");
		Console.WriteLine(car.number_of_tyres);
		Console.WriteLine(" : Is the number of wheels in a car \n");
		Console.WriteLine(motorcycle.number_of_tyres);
		Console.WriteLine(" Is the number of wheels in amotorcycle \n");
	}
}

