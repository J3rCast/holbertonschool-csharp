using System;


class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
		double[,] res = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int row = 0; row < res.GetLength(0); row++)
		{
			for (int col = 0; col < res.GetLength(1); col++)
			{
				res[row, col] = matrix[col, row];
			}
		}
		return res;
    }
}

