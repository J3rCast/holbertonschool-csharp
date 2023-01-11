using System;

class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
		double[,] fail = {{-1}};
		
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
			return fail;

		if (matrix1.GetLength(0) < 2 || matrix1.GetLength(0) > 3)
			return fail;
		if (matrix1.GetLength(1) < 2 || matrix1.GetLength(1) > 3)
			return fail;
		if (matrix1.GetLength(0) != matrix1.GetLength(1))
			return fail;

		double[,] res = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

		for (int row = 0; row < matrix1.GetLength(0); row++)
		{
			for (int col = 0; col < matrix1.GetLength(1); col++)
			{
				res[row, col] = matrix1[row, col] + matrix2[row, col]; 
			}
		}

		return res;
	}
}
