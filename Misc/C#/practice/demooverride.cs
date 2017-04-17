using System;
class demooverride
{	
	public int i,j,k,r;
	
	/*public demooverride(int x,int y,int j)
	{
		//accept();
		i=x;
		this.j=y;
		k=j;
	}*/
	public void accept()
	{
		Console.WriteLine("Enter First Number: ");
		i=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Second Number:");
		j=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Third Number:");
		k=Convert.ToInt32(Console.ReadLine());
	}
	public virtual void add()
	{
		r=i+j;
		Console.WriteLine("Final Result Is {0} ",r);
	}

}
class checkoverride1:demooverride
{
	/*public checkoverride1(int l,int m, int n):base (l,m,n)
	{
	}*/
	public override void add()
	{
		r=i+j+k;
		Console.WriteLine("Result is: {0}",r);
		
	}
}
class checkoverride
{
	public static void Main()
	{
		//demooverride d=new demooverride();
		checkoverride1 d1=new checkoverride1();
		d1.accept();
		d1.add();
		//d.accept();
		//d.add();
	}
}
		