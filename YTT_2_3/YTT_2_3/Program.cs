// УП Практическая работа 1.2
// Задание 3. Заполните квадратную матрицу n x n так, чтобы все числа первого столбца и первой строки равны 1, а каждое из оставшихся чисел равно сумме верхнего и левого соседей.
// Выведите на экран получившеюся матрицу

namespace YTT_2_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы: ");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n,n];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[0, i] = 1;
                array[i, 0] = 1;
            }
            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    array[i, j] = array[i - 1, j] + array[i, j - 1];
                }
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i,j]} ");
                }
                Console.WriteLine();
            }
            
        }
    }
}