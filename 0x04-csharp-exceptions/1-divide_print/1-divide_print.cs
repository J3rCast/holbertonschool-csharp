﻿using System;
using System.Collections.Generic;

class Int
{
	public static void divide(int a, int b)
	{
		try
		{
			int result = a / b;
		}
		catch (Exception)
		{
			Console.WriteLine("Cannot divide by zero");
		}
		finally
		{
			if (a == 0 || b == 0)
				Console.WriteLine("{0} / {1} = 0", a, b);
			else
				Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
		}
	}
}
