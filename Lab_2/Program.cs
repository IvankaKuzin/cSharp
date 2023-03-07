using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1,  2,  6 },
            { 4,  -5, 6 },
            { 9,  8,  9 }
        };

        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            bool containsNegative = false;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < 0)
                {
                    containsNegative = true;
                    break;
                }
                sum += matrix[i, j];
            }
            if (!containsNegative)
            {
                Console.WriteLine($"Sum elements in {i + 1} lines: {sum}");
            }
            sum = 0;
        }

        // Мінімум із сум діагоналей
        int diagonalCount = matrix.GetLength(0) + matrix.GetLength(1) - 1;
        int[] diagonalSums = new int[diagonalCount];
        int index;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                index = i - j + (matrix.GetLength(1) - 1);
                diagonalSums[index] += matrix[i, j];
            }
        }
        int minSum = diagonalSums[0];
        for (int i = 1; i < diagonalCount; i++)
        {
            if (diagonalSums[i] < minSum)
            {
                minSum = diagonalSums[i];
            }
        }
        Console.WriteLine($"Min sum diagonal: {minSum}");
    }
}
