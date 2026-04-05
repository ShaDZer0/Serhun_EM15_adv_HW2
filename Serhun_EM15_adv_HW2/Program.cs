using System;
using System.Linq;
using System.Collections.Generic;

namespace Serhum_EM15_adv_HW2
{
    internal class Program
    {
        static class Helper
        {
            public static void errorMessage(string message)
            {
                throw new Exception(message);
            }
            public static void showSeparator(string separator)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat(separator, 40)));
            }
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
                    errorMessage("Error! Число не може бути меньшим за " + min);
                }
                return value;
            }
            public static double inputDoubleNum(string message, int min, int max)
            {
                double value = inputDoubleNum(message);
                if (value < min || value > max)
                {
                    errorMessage($"Error! Число повинно бути більшим за {min} та меншим за {max}");
                }
                return value;
            }
            public static int[] fillArray(int[] array, int min, int max) 
            {
                Random random = new Random();
                for(int i = 0; i < array.Length; i++)
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
        static void Main(string[] args)
        {
            //Task 1
            /*
            try
            {
                Random random = new Random();
                const int SIZE = 1000, MIN = 1, MAX = 10;
                List<int> list = new List<int>();
                list.AddRange(Helper.fillArray(SIZE, MIN, MAX));
                Console.WriteLine("Масив:");
                Helper.showSeparator("=");
                Helper.printArray(list.ToArray());
                Helper.showSeparator("=");
                int num = 1, count = list.Count(x => x == num);
                for(int i = 1; i < MAX; i++)
                {
                    if(count < list.Count(x => x == i))
                    {
                        num = i;
                        count = list.Count(x => x == i);
                    }
                }
                Console.WriteLine($"Найчастіше зустрічається число: {num} (кількість: {count})");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            */
            //Task 2
            /*
            try
            {
                int size = (int)Helper.inputDoubleNum("Введіть розмір масиву: ", 1);
                int min = (int)Helper.inputDoubleNum("Введіть мінімальне значение: ");
                int max = (int)Helper.inputDoubleNum("Введіть максимальне значение: ", min + 1);
                int[] array = Helper.fillArray(size, min, max);
                Console.WriteLine("Масив:");
                Helper.sortArray(array);
                Helper.printArray(array);
                List<int> newArray = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    if(!newArray.Contains(array[i]))
                    {
                        newArray.Add(array[i]);
                    }
                }
                Console.WriteLine("Масив без повторів:");
                array = newArray.ToArray();
                Helper.printArray(array);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            */
            //Task 3
            /*
            try
            {
                const int MIN = 100, MAX = 900;
                int size = (int)Helper.inputDoubleNum("Введіть розмір масиву: ", 1);
                int[] array = Helper.fillArray(size, MIN, MAX);
                Helper.printArray(array);
                Console.WriteLine("Піки масиву:");
                if (array[0] >= array[1])
                    Console.Write(0 + " ");
                for (int i = 1; i < size-1; i++)
                {
                    if (array[i] >= array[i - 1] && array[i] >= array[i + 1])
                        Console.Write(i + " ");
                }
                if (array[size-1] >= array[size-2])
                    Console.WriteLine(size - 1);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            */
            //Task 4
            /*
            try
            {
                Console.Write("Введіть текст(анлійською мовою): ");
                string str = Console.ReadLine().ToLower().Trim();
                if (str.Length == 0)
                    Helper.errorMessage("Error! Текст не може бути пустим");
                if (!str.All(ch => ((ch >= 'a' && ch <= 'z')) || ch == ' '))
                    Helper.errorMessage("Error! Текст повинен бути англійською мовою");
                int count = 0;
                int[] charsCount = new int[26];
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ' && str[i+1] != ' ')
                        count++;
                    if (str[i] >= 'a' && str[i] <= 'z')
                        charsCount[str[i] - 'a']++;
                }
                Console.WriteLine($"Кількість слів: {count+1}");
                for (int i = 0; i < charsCount.Length; i++)
                {
                    if (charsCount[i] > 0)
                        Console.WriteLine($"Символ '{(char)(i + 'a')}' зустрічається {charsCount[i]} разів");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            */
            //Task 5
            /*
            const int SIZE = 20, MIN = 10, MAX = 99;
            int[] array = Helper.fillArray(SIZE, MIN, MAX);
            Console.WriteLine("Масив:");
            Helper.printArray(array);
            int sum = array[0] + array[1] + array[2], index = 0;
            for (int i = 1; i < SIZE - 2; i++)
            {
                if(sum < array[i] + array[i + 1] + array[i + 2])
                {
                    sum = array[i] + array[i + 1] + array[i + 2];
                    index = i;
                }
            }
            Console.WriteLine($"Найбільша сума трьох послідовних елементів: {sum} \nІндекси яких [{index}, {index+1}, {index+2}]");
            */
        }
    }
}