using System;
using System.Drawing;
using CompAndDel;

namespace CompAndDel.Filters
{
    public interface IConvolutionMatrix
    {
        int[,] MatrixElements {get;}
        int Complement {get;}
        int Divisor {get;}
    }
}