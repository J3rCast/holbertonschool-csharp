using System;

/// <summary>Contains multiple methods for objects </summary>
class Obj
{
	/// <summary>check if <see cref="object" /> is int. </summary>
	/// <returns>true if obj is int. </returns>
    public static bool IsOfTypeInt(object obj)
    {
		if (obj is int)
			return true;
		return false;
    }
}
