using System;
using System.Conditional;
class Debug
{
[conditional("TRACE")]
public void Trace(string s)
{
Console.WriteLine(s);
}
}
class MyClass
{
public static void Main()
{
Debug.Trace("hello");
}
}
