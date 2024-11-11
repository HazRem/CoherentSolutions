// Create two 3x3 diagonal matrices
using Task4_1;

var matrix1 = new DiagonalMatrix<int>(3);
var matrix2 = new DiagonalMatrix<int>(3);

matrix1[0, 0] = 1;
matrix1[1, 1] = 2;
matrix1[2, 2] = 3;

matrix2[0, 0] = 1;
matrix2[1, 1] = 2;
matrix2[2, 2] = 3;

// Adding matrices
var resultMatrix = matrix1.Add(matrix2, (x, y) => x + y);

Console.WriteLine("Result Matrix:");
for (int i = 0; i < resultMatrix.Size; i++)
{
    for (int j = 0; j < resultMatrix.Size; j++)
    {
        Console.Write(resultMatrix[i, j] + "\t");
    }
    Console.WriteLine();
}

// Tracking and Undoing changes
var tracker = new MatrixTracker<int>(matrix1);
matrix1[0, 0] = 10;
matrix1[1, 1] = 20;

Console.WriteLine("\nMatrix after changes:");
for (int i = 0; i < matrix1.Size; i++)
{
    for (int j = 0; j < matrix1.Size; j++)
    {
        Console.Write(matrix1[i, j] + "\t");
    }
    Console.WriteLine();
}

// Undo last change
tracker.Undo();
Console.WriteLine("\nMatrix after undo:");
for (int i = 0; i < matrix1.Size; i++)
{
    for (int j = 0; j < matrix1.Size; j++)
    {
        Console.Write(matrix1[i, j] + "\t");
    }
    Console.WriteLine();
}