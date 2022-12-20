using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;

/// <summary>Contains multiple methods for Obj.</summary>
class Obj
{
	/// <summary>Print object info.</summary>
	public static void Print(object myObj)
	{
		TypeInfo t = myObj.GetType().GetTypeInfo();
		IEnumerable<PropertyInfo> pList = t.DeclaredProperties;
		IEnumerable<MethodInfo> mList = t.DeclaredMethods;

		Console.WriteLine(myObj.GetType().Name + " Properties:");
		Console.WriteLine(myObj.GetType().Name + " Methods:");

		foreach (PropertyInfo p in pList)
		{
			Console.WriteLine(p.Name);
		}

		foreach (MethodInfo m in mList)
		{
			Console.WriteLine(m.Name);
		}

		Console.WriteLine(t.GetTypeInfo());
	}
}
