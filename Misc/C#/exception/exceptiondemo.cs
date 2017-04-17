using System;
class exceptiondemo
{
	public static void Main()
	{
		int [] a={12,13,15,6,9,8};
		int [] b={2,0,3,0,2};
		for(int i=0;i<a.Length;i++)
		{
			try
			{
				Console.WriteLine("Value Is :->"+a[i]/b[i]);
			}
			/*catch(DivideByZeroException)
			{
				Console.WriteLine("Cant devide by zero");
			}
			catch(IndexOutOfRangeException)
			{
				Console.WriteLine("Out of range");
			}*/
			catch
			{
				Console.WriteLine("Invalid Operation");
			}
			finally
			{
				Console.WriteLine("Terminate");
			}
		}
	}
}
