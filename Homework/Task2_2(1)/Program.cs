//The reason for such Task name is becasue the repo is still messed up and it claims i have projects there with name Task2_2 but i do not
//But at least i can still do the Tasks now.
//Thanks again for the one on one help :D

using Task2_2_1_;

DiagonalMatrix matrix1 = new DiagonalMatrix(1, 2, 3);
DiagonalMatrix matrix2 = new DiagonalMatrix(4, 5, 6, 7);

// Test ToString() output
Console.WriteLine("Matrix 1:");
Console.WriteLine(matrix1);
Console.WriteLine("Matrix 2:");
Console.WriteLine(matrix2);

// Test indexer
Console.WriteLine("Element [1,1] of Matrix 1: " + matrix1[1, 1]);
Console.WriteLine("Element [1,2] of Matrix 1: " + matrix1[1, 2]); // Should be 0

// Test Trace method
Console.WriteLine("Trace of Matrix 1: " + matrix1.Trace());
Console.WriteLine("Trace of Matrix 2: " + matrix2.Trace());

// Test Equals method
Console.WriteLine("Matrix 1 equals Matrix 2: " + matrix1.Equals(matrix2));

// Test addition of two matrices
DiagonalMatrix sumMatrix = matrix1.Add(matrix2);
Console.WriteLine("Sum of Matrix 1 and Matrix 2:");
Console.WriteLine(sumMatrix);
