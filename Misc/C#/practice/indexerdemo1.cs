using System;
class indexerdemo1
{
	int [] a;
	public int length;
	public bool errflag;
	public indexerdemo1(int size)
	{
		a=new int[size];
		length=size;
	}	
	public int this[int index]
	{
		get
		{
			if(ok(index))
			{
				errflag = false;
				return a[index];
			}
			else
			{
				errflag=true;
				return 0;
			}
		}
		set
		{
			if(ok(index))
			{
				a[index]=value;
				errflag = false;
			}
			else
			{
				errflag=true;
			}
		}
	}
	public bool ok(int index)
	{
		if(index>=0 & index<length) return true;
		return false;
	}
}
class demo
{
	public static void Main()
	{
		indexerdemo1 d1=new indexerdemo1(5);
		int x;
		for(int i=0; i<(d1.length*2); i++)
		{
			//Console.WriteLine("hello");
			d1[i]=i*10;
		}
		for(int i=0; i<(d1.length*2);i++)
		{
			
			//Console.WriteLine("hello1");
			//d1[i]=i*10;
			x=d1[i];
			Console.Write(x+" ");
			
		}
		Console.WriteLine("Enter out of bound specification");
		for(int i=0;i<(d1.length*2); i++)
		{
			d1[i]=i*10;
		}
		for(int i=0;i<(d1.length*2); i++)
		{
			x=d1[i];
			if(!d1.errflag)
			{
				Console.Write(x +" ");
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("x[" +i + " ] is out of bound");
			}
		}
		Console.WriteLine("Now enter out of bound area");
		
		for(int i=0;i<(d1.length*2); i++)
		{
			d1[i]=i*10;
			if(d1.errflag)
			{
				Console.WriteLine("x [" + i  + "] is out of bound");
			}
		}
		
		
		
	}
}