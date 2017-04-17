using System;
class prot
{
 protected  string Model;
	void Honk()
	{
		Console.WriteLine("Parrp Parrp");
	}
	public void setModel()
	{
		Console.WriteLine("Enter The Model Name:");
		Model = Console.ReadLine();
	}
 	public void displayModel()
	{
		Console.WriteLine("The Model Is:");
	}
}
class display
{
	static int Main(string [] args)
	{
		prot p=new prot();
		p.setModel();
		p.displayModel();
		//p.Honk();
		//Console.WriteLine(p.Model);
		return 0;
	}
}

