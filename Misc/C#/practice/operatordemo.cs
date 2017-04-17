using System;
class operatordemo
{
	public int x,y;
	public operatordemo()
	{
		x=y=0;
	}
	public operatordemo(int i, int j)
	{
		x=i;
		y=j;
		//z=k;
		//Console.WriteLine(x + " "+y);
	}
	public static operatordemo operator * (operatordemo op1, operatordemo op2)
	{
		//operatordemo result =new operatordemo();
		return new operatordemo ((op1.x*op2.x - op1.y*op2.y) , (op1.x*op2.y + op1.y*op2.x));
	}
	public static operatordemo operator ++(operatordemo op1)
	{
		//operatordemo result=new operatordemo();
		op1.x++;
		op1.y++;
		return op1;		
	}	
	public static operatordemo operator --(operatordemo op1)
	{
		//operatordemo result=new operatordemo();
		op1.x--;
		op1.y--;
		return op1;		
	}	
	/*public static bool operator false(operatordemo op1)
	{
		Console.WriteLine("From false optr");
		if((op1.x==0) && (op1.y==0))
		return true;
		else
		return false; 
	}

	public static bool operator true(operatordemo op1)
	{
		Console.WriteLine("From true optr");
		if((op1.x!=0) && (op1.y!=0))
		return true;
		else 
		return false;
	}*/
	
	public void show()
	{
		Console.WriteLine("Value Of X and Y {0}, {1}",x,y);
	}
}
class demo
{
	public static void Main()
	{
		operatordemo d1=new operatordemo(0,0);
		operatordemo d2=new operatordemo(2,2);
		operatordemo d3=new operatordemo();
		d3=d1*d2;
		d3.show();
		//d1++;
		d1.show();
		d2++;
		d2.show();

		if(d2) 
		Console.WriteLine("d2 is true");
		else
		Console.WriteLine("d2 is false");
		if(d1) 
		Console.WriteLine("d1 is true");
		else
		Console.WriteLine("d1 is false");
		//Console.WriteLine(d3);
		while(d2)
		{
		d2.show();
		d2--;
		}
	}
}
		
	
