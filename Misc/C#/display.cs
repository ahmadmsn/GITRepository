using System;
class display
{
	int number1, total;	
	display(int n)
	{
		number1=n;
	}	
	public void multiplication()
	{
		Console.WriteLine("Your Result Is:-");
		Console.WriteLine("----------------");
		for(int m=1; m<=10; m++)
		{
			total=number1*m;
			//add=total+total;
			Console.WriteLine(number1 +"*" +m +"=" +total);
			//Console.WriteLine(add);
		}
		
		Console.ReadLine();
		
	}
	public static void Main(string [] args)
	{
		int n2;
		Console.WriteLine("Enter The Number For See The Table");
		Console.WriteLine("----------------------------------");
		n2=Convert.ToInt32(Console.ReadLine());
		display d=new display(n2);
		d.multiplication();
	}
}