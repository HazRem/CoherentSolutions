

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
                if (!IsIndexValid(i, j)) 
                    return 0;
                return i == j ? diagonalElements[i] : 0;
            }
            set
            {
                if (!IsIndexValid(i, j))
                    return;
                if (i == j)
                    diagonalElements[i] = value;
            }
        }

        private bool IsIndexValid(int i, int j)
        {
            return i >= 0 && i < Size && j >= 0 && j < Size;
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
                    sb.Append(this[i, j].ToString());
                    sb.Append(" ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }

    
}
