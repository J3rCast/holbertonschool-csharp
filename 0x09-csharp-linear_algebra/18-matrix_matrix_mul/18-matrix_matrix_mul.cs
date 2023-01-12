using System;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
		double[,] fail = {{-1}};
		
		if (matrix1.GetLength(1) != matrix2.GetLength(0))
			return fail;

		double[,] res = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
		double mul = 0;

		for (int res_row = 0; res_row < res.GetLength(0); res_row++)
		{
			for (int res_col = 0; res_col < res.GetLength(1); res_col++)
			{
				mul = 0;
				for (int row = 0; row < matrix1.GetLength(1); row++)
				{
					mul += matrix1[res_row, row] * matrix2[row, res_col];
				}
				res[res_row, res_col] = mul;
			}
		}

		return res;
	}
}
