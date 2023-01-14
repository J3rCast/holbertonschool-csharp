using System;

class MatrixMath
{
	public static double Determinant(double[,] matrix)
    {
		double res = 0;

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
		{
			res = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
			return Math.Round(res, 2);
		}
		if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
		{
			double first = matrix[0, 0] * matrix[1, 1] * matrix[2, 2];
			first += matrix[1, 0] * matrix[2, 1] * matrix[0, 2];
			first += matrix[2, 0] * matrix[0, 1] * matrix[1, 2];

			double second = matrix[0, 2] * matrix[1, 1] * matrix[2, 0];
			second += matrix[1, 2] * matrix[2, 1] * matrix[0, 0];
			second += matrix[2, 2] * matrix[0, 1] * matrix[1, 0];
			res = first - second;
			return Math.Round(res, 2);
		}
		return -1;
    }

	public static double[,] Inverse2D(double[,] matrix)
    {
		double[,] fail = {{-1}};
		double det = Determinant(matrix);

		if (det == 0 || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
			return fail;

		double[,] transposed = {{matrix[1, 1], -1 * matrix[0, 1]}, {-1 * matrix[1, 0], matrix[0, 0]}};
		double[,] res = new double[2, 2];

		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < 2; j++)
				res[i, j] = Math.Round(transposed[i, j] / det, 2);
		}
		return res;
    }
}
