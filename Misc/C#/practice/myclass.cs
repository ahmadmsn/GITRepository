using System;
class myclass
{
	int alpha,beta;
	public myclass(int i,int j)
	{
		alpha=i;
		beta=j;
	}
	public bool sameas(myclass ob)
	{
		if((ob.alpha==alpha)&(ob.beta==beta))
		return true;
		else
		return false;
	}
	public void copy(myclass ob)
	{
		alpha=ob.alpha;
		beta=ob.beta;
	}
	public void show()
	{
		Console.WriteLine("alpha {0}, beta {1}",alpha,beta);
	}
	
}
class passob
{
	public static void Main()
	{
		myclass ob1=new myclass(4,5);
		myclass ob2=new myclass(6,7);

		Console.Write("ob1:  ");
		ob1.show();
		Console.Write("ob2:  ");
		ob2.show();

		if(ob1.sameas(ob2))
		Console.WriteLine("ob1 and ob2 have the same value");
		else
		Console.WriteLine("Ob1 and Ob2 have diffrent values");
	
		Console.WriteLine();

		ob1.copy(ob2);
		Console.WriteLine("Ob1 after copy");
		ob1.show();
		
		if(ob1.sameas(ob2))
		Console.WriteLine("ob1 and ob2 have the same value");
		else
		Console.WriteLine("Ob1 and o0b2 have diffrent values");
	}
}
		
