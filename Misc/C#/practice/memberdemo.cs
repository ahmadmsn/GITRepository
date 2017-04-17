using System;
class memberdemo
{
	public  int i=10;
	public void accept()
	{
		Console.WriteLine(i);
		i=20;
		Console.WriteLine(i);
		/*for(i=1;i<=10;i++)
		{
			int j=i;
			//i=i+1;
			Console.WriteLine(j);
		}*/
	}
	public void show()
	{
		Console.WriteLine(i);
	}
}
class demo
{
	public static void Main()
	{
		memberdemo m=new memberdemo();
		m.accept();
		m.show();
		//m.i=20;
		m.show();
	}
}