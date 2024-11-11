using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    public static class DiagonalMatrixExtensions
    {
        public static DiagonalMatrix<T> Add<T>(this DiagonalMatrix<T> matrix1, DiagonalMatrix<T> matrix2, Func<T, T, T> addFunc)
        {
            if (matrix1.Size != matrix2.Size)
                throw new ArgumentException("Matrices must be the same size for addition.");

            var resultMatrix = new DiagonalMatrix<T>(matrix1.Size);
            for (int i = 0; i < matrix1.Size; i++)
            {
                T value = addFunc(matrix1[i, i], matrix2[i, i]);
                resultMatrix[i, i] = value;
            }

            return resultMatrix;
        }
    }
}
