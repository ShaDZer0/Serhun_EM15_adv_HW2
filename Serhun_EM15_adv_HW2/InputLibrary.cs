using System;

namespace Library
{
    public class InputLibrary
    {
            public static double inputDoubleNum(string message)
            {
                Console.Write(message);
                return Convert.ToDouble(Console.ReadLine());
            }
            public static double inputDoubleNum(string message, double min = 0)
            {
                double value = inputDoubleNum(message);
                if (value < min)
                    ConsoleLibrary.errorMessage("Число не може бути меньшим за " + min);
                return value;
            }
            public static double inputDoubleNum(string message, int min, int max)
            {
                double value = inputDoubleNum(message);
                if (value < min || value > max)
                    ConsoleLibrary.errorMessage($"Число повинно бути більшим за {min} та меншим за {max}");
                return value;
            }
            public static int[] fillArray(int[] array, int min, int max)
            {
                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                    array[i] = random.Next(min, max + 1);
                return array;
            }
            public static int[] fillArray(int size, int min, int max)
            {
                Random random = new Random();
                int[] array = new int[size];
                return fillArray(array, min, max);
            }
            public static int[][] fillMatrix(int rows, int cols, int min, int max)
            {
                int[][] matrix = new int[rows][];
                for (int i = 0; i < rows; i++)
                {
                    matrix[i] = new int[cols];
                    fillArray(matrix[i], min, max);
                }
                return matrix;
            }
        }
}
