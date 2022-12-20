using System;
using System.Collections.Generic;

/// <summary>Contains multiple methods for Obj.</summary>
class Obj
{
	/// <summary>Check if is instace of a class.</summary>
	/// <returns>True if is instance.</returns>
	public static bool IsInstanceOfArray(object obj)
	{
		if (obj is Array)
			return true;
		return false;
	}
}
