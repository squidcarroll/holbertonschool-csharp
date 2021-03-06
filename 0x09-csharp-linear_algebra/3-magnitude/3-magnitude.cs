﻿using System;
using System.Math;

/*
    gets magnitude
 */
class VectorMath
{
    /// <summary>
    /// Finds magnitude of vector
    /// </summary>
    /// <param name="vector">vector to check</param>
    /// <returns>length of vector</returns>
    public static double Magnitude(double[] vector)
    {
        double res = -1;
        if (vector.Length == 2) {
            res = Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)), 1);
        } else if (vector.Length == 3) {
            res = Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)), 1);
        } else {
            return res;
        }   
        return res;
    }
}
