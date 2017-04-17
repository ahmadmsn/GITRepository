using System;
class indexerdemo
{
	int [] a;
	//public int size;
	public bool errflag;
	public int length;
	public indexerdemo(int size)
	{
		a=new int[size];
		length=size;
	}
	public int this [int index]
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
				errflag=false;
			}
			else errflag=true;
			
		}
		
	}
	private bool ok(int index)
	{
		if(index >=0 & index<length) return true;
		return false;
	}
}
class demo
{
	public static void Main()
	{
		indexerdemo d=new indexerdemo(5);
		int x;
		for(int i=0; i < (d.length * 2); i++)
		{
			d[i] = i * 10;
			x=d[i];
			Console.Write(x);
		}
		/*for(int i=0; i<(d.length*2); i++)
		{
			x = d[i];
			if(x! = -1) Console.Write(x);
		}*/
		Console.WriteLine();
		Console.WriteLine("Show Out-Of-bound");
		for(int i=0;i<(d.length*2);i++)
		{
			d[i]=i*10;
			if(d.errflag)
			Console.WriteLine( "d ["+i+"] out of bound");
		}
		for(int i=0;i<(d.length*2); i++)
		{
			x=d[i];
			if(!d.errflag)
			Console.Write(x+ " ");
			else
			Console.WriteLine("d ["+i+"] out of bound");
		}
	}
}
			

