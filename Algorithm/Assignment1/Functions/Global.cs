using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Functions
{
    public class Global
    {
        public static int[][] generateMatrix(int dim)
        {
            int[][] array = new int[dim][];
            Array.Clear(array, 0, array.Length);
            Random random = new Random();
            int[] randomNiz = new int[dim];
            for (int i = 0; i < dim; i++)
            {
                array[i] = new int[dim];
                randomNiz[i] = random.Next(0, dim);
            }
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (j == randomNiz[i])
                    {
                        array[j][i] = 1;
                        break;
                    }
                }
            }
            return array;
        }
        public static int[] matrixToArray(int[][] matrix, int dim)
        {
            int[] array = new int[dim * dim];
            int counter = 0;
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    array[counter++] = matrix[i][j];
                }
            }
            return array;
        }
        public static int Heuristic(int[][] matrix, int dim)
        {
            int heuristic = 0;
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        for (int k = 0; k < dim; k++)
                        {
                            for (int n = j + 1; n < dim; n++)
                            {
                                if (k == i)
                                {
                                    if (matrix[k][n] == 1)
                                    {
                                        heuristic++;
                                    }
                                }
                                else if (k + n == i + j)
                                {
                                    if (matrix[k][n] == 1)
                                    {
                                        heuristic++;
                                    }
                                }
                                else if (k - i == n - j)
                                {
                                    if (matrix[k][n] == 1)
                                    {
                                        heuristic++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return heuristic;
        }
        public static int[][] CopyMatrix(int[][] matrix, int dim)
        {
            int[][] matrix2 = new int[dim][];
            for (int i = 0; i < dim; i++)
            {
                matrix2[i] = new int[dim];
                for (int j = 0; j < dim; j++)
                {
                    matrix2[i][j] = matrix[i][j];
                }
            }
            return matrix2;
        }
        public static int[] StringToInt(string stringArray, int dim)
        {
            int[] array = new int[dim * dim];
            for (int i = 0; i < dim * dim; i++)
            {
                array[i] = (int)Char.GetNumericValue(stringArray, i);
            }
            return array;
        }
        public static int[][] arrayToMatrix(int[] array, int dim)
        {
            int[][] matrix = new int[dim][];
            int counter = 0;
            for (int i = 0; i < dim; i++)
            {
                matrix[i] = new int[dim];
                for (int j = 0; j < dim; j++)
                {
                    matrix[i][j] = array[counter++];
                }
            }
            return matrix;
        }
        public static int[][] randomSuccessor(int[][] matrix, int dim)
        {
            int row = new Random().Next(0, dim);
            int column = new Random().Next(0, dim);

            while (matrix[row][column] == 1)
            {
                row = new Random().Next(0, dim);
                column = new Random().Next(0, dim);
            }
            for (int i = 0; i < dim; i++)
            {
                if (matrix[i][column] == 1)
                {
                    matrix[i][column] = 0;
                    break;
                }
            }
            matrix[row][column] = 1;

            return matrix;
        }
    }
}
