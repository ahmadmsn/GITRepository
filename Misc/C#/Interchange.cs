using System;
class Interchange
{
	int Top_Score;
	int New_Score;
	int Temp;
	void swap()
	{
		Top_Score=5;
		New_Score=10;
		Temp=New_Score;
		New_Score=Top_Score;
		Top_Score=Temp;
	}
	void display()
	{
		Console.WriteLine("The new value of Top Score Is : {0}" , Top_Score);
		Console.WriteLine("The old value of Top Score was : {0}" , New_Score);
	}
	static void Main()
	{
		Interchange i = new Interchange();
		i.swap();
		i.display();
	}
}
	