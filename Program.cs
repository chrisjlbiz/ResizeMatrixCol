using System;

namespace Console1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] matrix1 = new int[3, 4]
            {
                {1,1,1,1},
                {2,2,2,2},
                {3,3,3,3}
            };

            var matrix = ResizeMatrixColumn(matrix1, 6, 2);

            Console.WriteLine("Before :");
            Print(matrix1);
            Console.WriteLine();
            Console.WriteLine("After :");
            Print(matrix);
        }

        /// <summary>
        /// <para>Resizes a multidimensional array by adding/removing a column at the end.</para>
        /// Use indexNewCol to determine where to insert or delete a column.
        /// </summary>
        static int[,] ResizeMatrixColumn(int[,] matrix, int newColCount, int indexNewCol = -1)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            int minCol = Math.Min(newColCount, col);

            int[,] newMatrix = new int[row, newColCount];

            if (indexNewCol == -1 || indexNewCol > minCol)
            {
                for (int i = 0; i < row; i++)
                {
                    int sourceIndex = i * col;
                    int destIndex = i * newColCount;

                    Array.Copy(matrix, sourceIndex, newMatrix, destIndex, minCol);
                }
            }
            else
            {
                int lengthNewCol = minCol - indexNewCol;
                if (newColCount <= col) lengthNewCol -= 1;

                for (int i = 0; i < row; i++)
                {
                    int sourceIndex = i * col;
                    int destIndex = i * newColCount;

                    Array.Copy(matrix, sourceIndex, newMatrix, destIndex, indexNewCol);

                    int sourceIndex2 = sourceIndex + indexNewCol;
                    int destIndex2 = destIndex + indexNewCol + 1;

                    Array.Copy(matrix, sourceIndex2, newMatrix, destIndex2, lengthNewCol);
                }
            }
            return newMatrix;
        }

        static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
