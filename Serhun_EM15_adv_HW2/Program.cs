using System;
using System.Linq;
using System.Collections.Generic;
using Library;

namespace Serhum_EM15_adv_HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            /*
            try
            {
                Random random = new Random();
                const int SIZE = 1000, MIN = 1, MAX = 10;
                List<int> list = new List<int>();
                list.AddRange(InputLibrary.fillArray(SIZE, MIN, MAX));
                Console.WriteLine("Масив:");
                ConsoleLibrary.showSeparator("=");
                ConsoleLibrary.printArray(list.ToArray());
                ConsoleLibrary.showSeparator("=");
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
                int size = (int)InputLibrary.inputDoubleNum("Введіть розмір масиву: ", 1);
                int min = (int)InputLibrary.inputDoubleNum("Введіть мінімальне значение: ");
                int max = (int)InputLibrary.inputDoubleNum("Введіть максимальне значение: ", min + 1);
                int[] array = InputLibrary.fillArray(size, min, max);
                Console.WriteLine("Масив:");
                ConsoleLibrary.sortArray(array);
                ConsoleLibrary.printArray(array);
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
                ConsoleLibrary.printArray(array);
            }
            catch (Exception e)
            {
                ConsoleLibrary.errorColor();
                throw new Exception(e.Message);
            }
            */
            //Task 3
            /*
            try
            {
                const int MIN = 100, MAX = 900;
                int size = (int)InputLibrary.inputDoubleNum("Введіть розмір масиву: ", 1);
                int[] array = InputLibrary.fillArray(size, MIN, MAX);
                ConsoleLibrary.printArray(array);
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
                ConsoleLibrary.errorColor();
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
                    ConsoleLibrary.errorMessage("Текст не може бути пустим");
                if (!str.All(ch => ((ch >= 'a' && ch <= 'z')) || ch == ' '))
                    ConsoleLibrary.errorMessage("Текст повинен бути англійською мовою");
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
                ConsoleLibrary.errorColor();
                throw new Exception(e.Message);
            }
            */
            //Task 5
            /*
            {
                const int SIZE = 20, MIN = 10, MAX = 99;
                int[] array = InputLibrary.fillArray(SIZE, MIN, MAX);
                Console.WriteLine("Масив:");
                ConsoleLibrary.printArray(array);
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
            }
            */
        }
    }
}