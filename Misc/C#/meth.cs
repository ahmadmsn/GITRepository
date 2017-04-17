using System;
class meth
{
	public int addnumber()
	{
		int num1;
		int num2;
		int result;
		Console.WriteLine("Enter The First Number");
		num1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter The 2nd Number");
		num2=Convert.ToInt32(Console.ReadLine());
		result=num1+num2;
		return result;
	}
	/*public static void Main(string [] args)
	{
		meth m=new meth();
		int value=m.addnumber();
		Console.WriteLine("Added Number Is {0}", value);
		Console.ReadLine();
	}*/
}
class calcularor
{
	public static void Main(string [] args)
	{
		meth m=new meth();
		int value=m.addnumber();
		Console.WriteLine("Added Number Is {0}", value);
		Console.ReadLine();
	}
}

