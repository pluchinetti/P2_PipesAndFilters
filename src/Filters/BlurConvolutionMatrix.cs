using System;
using System.Drawing;
using CompAndDel;

namespace CompAndDel.Filters
{
    public class BlurConvolutionMatrix : IConvolutionMatrix
    {
        public int[,] MatrixElements {get; private set;}
        
        public int Complement {get; private set;}
        public int Divisor {get; private set;}

        public BlurConvolutionMatrix()
        {
            this.MatrixElements = new int[3,3];
            this.Complement = 0;
            this.Divisor = 9;
            
            for (int x = 0; x < 3 ; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    MatrixElements[x,y] = 1;
                }
            }
        }
    }
}