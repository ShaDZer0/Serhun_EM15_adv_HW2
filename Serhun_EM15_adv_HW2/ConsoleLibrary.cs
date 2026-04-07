using System;
using System.Linq;

namespace Library
{
    public class ConsoleLibrary
    {
        public static void errorColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public static void errorMessage(string message)
        {
            errorColor();
            throw new Exception($"Error! {message}");
        }
        public static void showSeparator(string separator)
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat(separator, 40)));
        }
        public static void printArray(int[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }
        public static void sortArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        }
    }

