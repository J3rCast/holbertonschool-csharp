using System;


class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] fail = {-1};
        if (vector.Length < 2 || vector.Length > 3)
            return fail;

        double[] res = new double[vector.Length];
        for (int i = 0; i < res.Length; i++)
            res[i] = vector[i] * scalar;
        
        return res;
    }
}
