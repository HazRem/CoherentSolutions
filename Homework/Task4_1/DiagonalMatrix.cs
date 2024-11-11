namespace Task4_1
{
    public class DiagonalMatrix<T>
    {
        private readonly T[] _elements;
        public int Size { get; }
        public event EventHandler<ElementChangedEventArgs<T>> ElementChanged;

        public DiagonalMatrix(int size)
        {
            if (size < 0)
                throw new ArgumentException("Size cannot be negative.", nameof(size));

            Size = size;
            _elements = new T[size];
        }

        public T this[int i, int j]
        {
            get
            {
                ValidateIndices(i, j);
                return i == j ? _elements[i] : default;
            }
            set
            {
                ValidateIndices(i, j);

                if (i == j)
                {
                    T oldValue = _elements[i];
                    if (!Equals(oldValue, value))
                    {
                        _elements[i] = value;
                        OnElementChanged(i, j, oldValue, value);
                    }
                }
            }
        }

        private void ValidateIndices(int i, int j)
        {
            if (i < 0 || j < 0 || i >= Size || j >= Size)
                throw new IndexOutOfRangeException("Index is out of range.");
        }

        protected virtual void OnElementChanged(int i, int j, T oldValue, T newValue)
        {
            ElementChanged?.Invoke(this, new ElementChangedEventArgs<T>(i, j, oldValue, newValue));
        }
    }

    public class ElementChangedEventArgs<T> : EventArgs
    {
        public int Row { get; }
        public int Column { get; }
        public T OldValue { get; }
        public T NewValue { get; }

        public ElementChangedEventArgs(int row, int column, T oldValue, T newValue)
        {
            Row = row;
            Column = column;
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}
