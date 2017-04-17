using System;
using System.Collections;
class testarraylist
{
	public static void Main()
	{
		ArrayList a=new ArrayList();
		a.Add('A');
		a.Add('B');
		a.Add('C');
		a.Add('D');
		a.Insert(4,'B');
		a.Insert(3,'B');
		int j=a.IndexOf('B');
		int k=a.LastIndexOf('B');
		Console.WriteLine("Index Is {0}",j);
		Console.WriteLine("Index Is {0}",k);
		Console.WriteLine(a[0]);
		a.Reverse();
		a.Sort();
		/*int index=0;
		foreach(char c in a)
		{
			if(c=='B')
			Console.WriteLine("Index of B is{0}",index);
			index++;
		}*/
		foreach(char i in a)
		{
			Console.WriteLine("Total Character Is {0}",i);
		}
		/*for(int l=0;l<=25;l++)
		{
			a.Add((char)('a' + l));
		}
		foreach(char m in a)
		{
			Console.WriteLine("After Adding  {0}  ",m);
		}*/
	}
}