using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2_1_
{
    using System;
    using System.Text;

    public class DiagonalMatrix
    {
        private int[] diagonalElements;

        public int Size { get; private set; }

        public DiagonalMatrix(params int[] elements)
        {
            if (elements == null)
            {
                Size = 0;
                diagonalElements = new int[0];
            }
            else
            {
                Size = elements.Length;
                diagonalElements = new int[Size];
                Array.Copy(elements, diagonalElements, Size);
            }
        }

        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= Size || j < 0 || j >= Size)
                    return 0;
                return i == j ? diagonalElements[i] : 0;
            }
            set
            {
                if (i < 0 || i >= Size || j < 0 || j >= Size)
                    return;
                if (i == j)
                    diagonalElements[i] = value;
            }
        }

        public int Trace()
        {
            int sum = 0;
            foreach (int element in diagonalElements)
                sum += element;
            return sum;
        }

        public override bool Equals(object obj)
        {
            if (obj is DiagonalMatrix other && Size == other.Size)
            {
                for (int i = 0; i < Size; i++)
                {
                    if (diagonalElements[i] != other.diagonalElements[i])
                        return false;
                }
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    sb.Append(i == j ? diagonalElements[i].ToString() : "0");
                    sb.Append(" ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }

    public static class DiagonalMatrixExtensions
    {
        public static DiagonalMatrix Add(this DiagonalMatrix matrix1, DiagonalMatrix matrix2)
        {
            int maxSize = Math.Max(matrix1.Size, matrix2.Size);
            int[] resultElements = new int[maxSize];

            for (int i = 0; i < maxSize; i++)
            {
                int element1 = i < matrix1.Size ? matrix1[i, i] : 0;
                int element2 = i < matrix2.Size ? matrix2[i, i] : 0;
                resultElements[i] = element1 + element2;
            }

            return new DiagonalMatrix(resultElements);
        }
    }
}
