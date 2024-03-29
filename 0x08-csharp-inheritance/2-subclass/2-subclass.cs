﻿using System;

/// <summary>Contains multiple methods for Obj.</summary>
class Obj
{
	/// <summary>check if derivedType is a subclass of baseType.</summary>
	/// <returns>True if is a subclass.</returns>
	public static bool IsOnlyASubclass(Type derivedType, Type baseType)
	{
		if (derivedType.IsSubclassOf(baseType))
			return true;
		return false;
	}
}
