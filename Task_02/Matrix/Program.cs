using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
            Console.Write("Введите ширину массива: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, m]; //Объявляем массив строк длиной n и шириной m (которую ввёл пользователь)
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                metka:
                    try
                    {
                        Console.Write("Введите элемент №{0}{1}:\r\n    ", i, j);
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine()); //Заполняем его
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Вводите только целые числа!");
                        goto metka;
                    }
                }
            PrintArray(matrix);

            int minI = 0, minJ = 0, maxI = 0, maxJ = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[minI, minJ] > matrix[i, j])
                    {
                        minI = i;
                        minJ = j;
                    }
                    else if (matrix[maxI, maxJ] < matrix[i, j])
                    {
                        maxI = i;
                        maxJ = j;
                    }
                }
            }

            Console.WriteLine("Минимальный элемент: {0}\tМаксимальный максимальный: {1}", matrix[minI, minJ], matrix[maxI, maxJ]);

            var tmp = matrix[maxI, maxJ];
            matrix[maxI, maxJ] = matrix[minI, minJ];
            matrix[minI, minJ] = tmp;

            PrintArray(matrix);
            Console.ReadKey();
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

/*
 * уточнить по использованию локальных переменных, размещенных в блоке try
 * за переделами блока
*/