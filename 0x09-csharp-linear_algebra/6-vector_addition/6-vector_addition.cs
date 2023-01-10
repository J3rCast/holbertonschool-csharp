using System;

/// <summary>
/// This class contains multiple methods for vectors.
/// </summary>
class VectorMath
{
    /// <summary>
    /// This method adds two vectors.
    /// </summary>
    /// <param name="vector1">first vector</param>
    /// <param name="vector2">Second vector</param>
    /// <returns>new vector with the sums.</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] fail = {-1};
        if (vector1.Length != vector2.Length)
            return fail;

        if ((vector1.Length == 2 || vector1.Length == 3) && (vector2.Length == 2 || vector2.Length == 3))
        {
            double[] res = new double[vector1.Length];
            for (int i = 0 ; i < vector1.Length ; i++)
                res[i] = vector1[i] + vector2[i];
            
            return res;
        }
        return fail;
    }
}
