using System;
class Geometrical_shapes
{
	double No_of_coordinates;
	//double Area;
	//string Color;
	public void create()
	{
		Console.WriteLine(" Enter The Number Of Coordinates");
		No_of_coordinates = Console.ReadLine();
	}
}

class geometry
{
	public static void Main(string [] args)
	{
		Geometrical_shapes g = new Geometrical_shapes();
		g.create();
	}
}