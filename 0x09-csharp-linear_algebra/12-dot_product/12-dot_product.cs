using System;

class VectorMath
{
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length)
            return -1;
        if (vector1.Length < 2 || vector1.Length > 3)
            return -1;

        double product = 0;
        double[] res = new double[vector1.Length];

        for (int i = 0; i < vector1.Length; i++)
            res[i] = vector1[i] * vector2[i];
        
        for (int j = 0; j < res.Length; j++)
            product += res[j];
        
        return product;
    }
}

