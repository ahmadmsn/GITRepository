using System;
using System.Collections;
using System.Reflection;
class reflectiondemo
{
	public static void Main()
	{
		ArrayList a=new ArrayList();
		Type t= typeof(ArrayList);
		Console.WriteLine("Analyzing class in "+t.Name);
		Console.WriteLine("The Methods are-->");
		MethodInfo [ ] m=t.GetMethods();
		foreach(MethodInfo x in m)
		{
		Console.WriteLine(x.ReturnType.Name+" "+x.Name);
		ParameterInfo [ ] p=x.GetParameters();
		for(int i=0;i<p.Length;i++)
		Console.Write(p[i].ParameterType.Name+" "+p[i].Name+"\t");
		Console.WriteLine();
		}
	
	}
}