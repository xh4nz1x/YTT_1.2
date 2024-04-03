// УП Практическая работа 1.2
// Задание 2. Заполните массив последовательными нечетными числами, начиная с 1

namespace YTT_2_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[30];
            int num = -1;
            for (int i = 0; i < array.Length; i++)
            {
                num += 2;
                array[i] = num;
            }

            Console.Write("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}