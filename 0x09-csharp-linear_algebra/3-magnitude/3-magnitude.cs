using System;

/// <summary>
/// This class contains multiple methods for vectors.
/// </summary>
class VectorMath
{
    /// <summary>
    /// This method allows to find the magnitud of a 2D or 3D vector.
    /// </summary>
    /// <param name="vector">Vector to find the magnitud</param>
    /// <returns>Magnitud of the vector.</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
            double res = Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2);
            return Math.Round(Math.Sqrt(res), 2);
        }
        if (vector.Length == 3)
        {
            double res = Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2);
            return Math.Round(Math.Sqrt(res), 2);
        }
        
        return -1;
    }
}

