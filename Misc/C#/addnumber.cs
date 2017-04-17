using System;
class addnumber
{
	public static void Main(string [] args)
	{
		int sumnum, incr, number;
		for(sumnum=number=incr=0; incr<5; incr+=1)
		{
			Console.WriteLine("Enter Positive Number");
			number=Convert.ToInt32(Console.ReadLine());
			//if(number <=0)
			//continue;
			sumnum=sumnum+number;
		}
		Console.WriteLine(" The sum of Positive number {0}", sumnum);
		Console.ReadLine();
	}
}
		