using System;
class enumtest
{
	enum days{sat,sun,mon,tue,wed,thu,fri};
	public static void Main()
	{
		int first_day=(int)days.sat;
		int last_day=(int)days.fri;
		Console.WriteLine("Sat ={0}",first_day);
		Console.WriteLine("Fri ={0}",last_day);
	}
}