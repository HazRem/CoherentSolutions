using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    public class MatrixTracker<T>
    {
        private readonly DiagonalMatrix<T> _matrix;
        private readonly Stack<(int, int, T)> _history = new Stack<(int, int, T)>();

        public MatrixTracker(DiagonalMatrix<T> matrix)
        {
            _matrix = matrix;
            _matrix.ElementChanged += OnElementChanged;
        }

        private void OnElementChanged(object sender, ElementChangedEventArgs<T> e)
        {
            _history.Push((e.Row, e.Column, e.OldValue));
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                var (row, col, oldValue) = _history.Pop();
                _matrix[row, col] = oldValue;
            }
        }
    }
}
