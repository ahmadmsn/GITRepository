using System;
class Class1
{
private string[] MyField;
public string[] MyProperty
{
get { return MyField; }
set { MyField = value; }
}
}
class MainClass
{
public static int Main(string[] args)
{
Class1 c = new Class1();
string[] arr = new string[] {"apple", "banana"};
c.MyProperty = arr;
Console.WriteLine(c.MyProperty[0]); // "apple"
return 0;
}
}