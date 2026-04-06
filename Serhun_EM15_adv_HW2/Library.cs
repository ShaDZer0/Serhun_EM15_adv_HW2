using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class InputLibrary
    {
        public static double inputDoubleNum(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }
        public static double inputDoubleNum(string message, double min)
        {
            double value = inputDoubleNum(message);
            if (value < min)
            {
                ConsoleLibrary.errorMessage("Число не може бути меньшим за " + min);
            }
            return value;
        }
        public static double inputDoubleNum(string message, int min, int max)
        {
            double value = inputDoubleNum(message);
            if (value < min || value > max)
            {
                ConsoleLibrary.errorMessage($"Число повинно бути більшим за {min} та меншим за {max}");
            }
            return value;
        }
        public static int[] fillArray(int[] array, int min, int max)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(min, max + 1);
            }
            return array;
        }
        public static int[] fillArray(int size, int min, int max)
        {
            Random random = new Random();
            int[] array = new int[size];
            return fillArray(array, min, max);
        }
    }
}
