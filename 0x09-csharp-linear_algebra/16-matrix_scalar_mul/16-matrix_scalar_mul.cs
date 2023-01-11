using System;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
		double[,] fail = {{-1}};
		
		// check if the high is 2 or 3, return fail otherwise.
		if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3)
			return fail;
		// check if the witdh is 2 or 3, return fail otherwise.
		if (matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
			return fail;
		// check if the high and the witdh are the same, return fail otherwise.
		if (matrix.GetLength(0) != matrix.GetLength(1))
			return fail;

		double[,] res = new double[matrix.GetLength(0), matrix.GetLength(1)];

		for (int row = 0; row < matrix.GetLength(0); row++)
		{
			for (int col = 0; col < matrix.GetLength(1); col++)
			{
				res[row, col] = matrix[row, col] * scalar; 
			}
		}

		return res;
	}
}
