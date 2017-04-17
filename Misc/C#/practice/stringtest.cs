using System; 
public class StringTest
{
	public static void Main(string[] args)
	{
		Object nullObj = null; Object realObj = new StringTest();
		int i = 10;
		Console.WriteLine(\"Null Object is [\" + nullObj + \"]\n\"+ \"Real Object is [\" + realObj + \"]\n\"
				+ \"i is [\" + i + \"]\n\");
		// Show string equality operators
		string str1 = \"foo\";
		string str2 = \"bar\";
		string str3 = \"bar\";
		Console.WriteLine(\"{0} == {1} ? {2}\", str1, str2, str1 == str2 );
		Console.WriteLine(\"{0} == {1} ? {2}\", str2, str3, str2 == str3 );
	}
}
