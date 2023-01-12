using System;

class MatrixMath
{
	public static double[,] new_matrix(double[,] matrix)
	{
		double[,] res = new double[5, 3];
		int row_controller = 0;
		int col_controller = 0;

		for (int row = 0; row < 5; row++)
		{
			for (int col = 0; col < 3; col++)
			{
				if (row >= 3)
				{
					res[row, col] = matrix[row_controller, col_controller];
					col_controller += 1;
				}
				else
					res[row, col] = matrix[row, col];
			}
			col_controller = 0;
			if (row >= 3)
				row_controller += 1;
		}
		return res;
	}
    public static double Determinant(double[,] matrix)
    {
		double res = 0;

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
		{
			res = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
			return res;
		}
		if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
		{
			double[,] res_matrix = new_matrix(matrix);

			double first = res_matrix[0, 0] * res_matrix[1, 1] * res_matrix[2, 2];
			first += res_matrix[1, 0] * res_matrix[2, 1] * res_matrix[3, 2];
			first += res_matrix[2, 0] * res_matrix[3, 1] * res_matrix[4, 2];

			double second = res_matrix[0, 2] * res_matrix[1, 1] * res_matrix[2, 0];
			second += res_matrix[1, 2] * res_matrix[2, 1] * res_matrix[3, 0];
			second += res_matrix[2, 2] * res_matrix[3, 1] * res_matrix[4, 0];
			res = first - second;
			return res;
		}
		return -1;
    }
}
