// УП Практическая работа 1.2
// Задание 1. Создайте коллекцию (массив) размерностью 100.
// Добавьте в коллекцию числа в убывающем порядке, каждое число меньше предыдущего на 3


namespace YTT_2_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[100];
            array[0] = 450;
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = array[i - 1] - 3;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write($"{array[i]} ");
            }
        }
    }
}