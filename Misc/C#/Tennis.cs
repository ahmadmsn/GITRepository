using System;
class TennisPlayer
{
	string name;
	string rank;
	public void acceptdetails()
	{
		Console.WriteLine("Enter The Details Of Tennis Palyer");
		Console.WriteLine("\n-----------------------------------------------");
		Console.WriteLine("\n Enter The Name Of Tennis Palyer");
		name=Console.ReadLine();
		Console.WriteLine("\n Enter The Rank Of Tennis Palyer");
		rank=Console.ReadLine();
	}
	public void display()
	{
		Console.WriteLine(" Details Of TennisPlayer");
		Console.WriteLine("\n -------------------------------");
		Console.WriteLine("\n Name of Tennis Palyer:");
		Console.WriteLine(name);
		Console.WriteLine("\n Name of the Rank");
		Console.WriteLine(rank);
	}
}
class Tennis
{
	public static void Main(string [] args)
	{
		TennisPlayer t1= new TennisPlayer();
		t1.acceptdetails();
		t1.display();
	}
}
		



































































