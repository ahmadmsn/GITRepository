using System;
class indexdemo4
{
	public int [] a;
	public int len;
	public bool errflag;
	public indexdemo4(int size)
	{
		a=new int[size];
		len=size;
	}
	public int this[int index]
	{
		get
		{
			if(ok (index))
			{
				errflag=false;
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
			else
			{
				errflag=true;
			}
		}
	}
	public bool ok(int index)
	{
		if(index >= 0 &  index < len) return true;
		return false;
	}
}
class demo
{
	public static void Main()
	{
		indexdemo4  d = new indexdemo4 (5);
		int x;
		for(int i=0; i<(d.len*2);i++)
		{
			
			d[i]=i;
			x=d[i];
			Console.Write(x+ " ");
		}
	}
}
		
		
