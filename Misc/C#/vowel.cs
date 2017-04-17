using System;
class vowel
{
	public static void Main(string [] args)
	{
		char option;
		Console.WriteLine("Enter Ur Character for Vowel Or Constant");
		option = Convert.ToChar(Console.ReadLine());
		switch(option)
		{
			case 'a':
			Console.WriteLine("Character Is Vowel");
			break;

			case 'e':
			Console.WriteLine("Character Is Vowel");
			break;

			case 'i':
			Console.WriteLine("Character Is Vowel");
			break;
		
			case 'o':
			Console.WriteLine("Character Is Vowel");
			break;

			case 'u':
			Console.WriteLine("Character Is Vowel");
			break;

			default:
			Console.WriteLine("Character Is Consunant");
			break;
		}
	}
}