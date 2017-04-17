using System;
namespace PrimarySchool
{
	class DayCount
	{
		int Month;
		int Year;
		int Days;
		public DayCount()
		{
			Month=0;
			Year=0;
		}
		public Boolean LeapYear()
		{
			if ((Year % 4 == 0 ) && (Year % 100 !=0 || Year % 400 ==0))
			return true;
			else
			return false;
		}
		public void setDate(int month1, int year1)
		{
			Month=month1;
			Year=year1;
		}
		public void setDate(int month1)
		{
			Month=month1;
			Year=2006;
		}
		public string monthName()
		{
			switch (Month)
			{
				case 1: return "January";
				case 2: return "February";
				case 3: return "March";
				case 4: return "April";
				case 5: return "May";
				case 6: return "June";
				case 7: return "July";
				case 8: return "August";
				case 9: return "September";
				case 10: return "October";
				case 11: return "November";
				case 12: return "December";
				
				default : return "Invalid Month Name";
			}
		}
		public void setDays()
		{
			switch (Month)
			{
				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:	
				{
					Days=31;
					break;
				}		
				case 2:
				{
					Days =28;
					if(LeapYear())
					Days=29;
					 break;
				}
				case 4:
				case 6:
				case 9:
				case 11:
				{
					Days=30;
					break;
				}
			}
		}
		public void display()
		{
			//string [] name= new string[25];
			setDays();
			Console.WriteLine("The Number Of Days in The Month Of " +monthName());
			Console.WriteLine(Days);
		}
		static void Main()
		{
			DayCount dayCount=new DayCount();
			int month,year;
			Console.WriteLine("Enter The Month in Number");
			month=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter The Year");
			year=Convert.ToInt32(Console.ReadLine());
			dayCount.setDate(month, year);
			dayCount.setDate(month);
			dayCount.display();
			Console.ReadLine();
		}
	}
}
					
			
