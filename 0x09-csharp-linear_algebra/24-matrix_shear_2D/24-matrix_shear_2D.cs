using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
		double[,] fail = {{-1}};

		if (matrix.Length != 4 || (direction != 'x' && direction != 'y'))
			return fail;
		if (matrix.GetLength(0) != matrix.GetLength(1))
			return fail;

		double[,] res = new double[2, 2];

		if (direction == 'x')
		{

			res[0, 0] = matrix[0, 0] + factor * matrix[0, 1];
			res[1, 0] = matrix[1, 0] + factor * matrix[1, 1];
			res[0, 1] = matrix[0, 1];
			res[1, 1] = matrix[1, 1];
		}
		if (direction == 'y')
		{
			res[0, 1] = matrix[0, 1] + factor * matrix[0, 0];
			res[1, 1] = matrix[1, 1] + factor * matrix[1, 0];
			res[0, 0] = matrix[0, 0];
			res[1, 0] = matrix[1, 0];
		}
		return res;
    }
}
