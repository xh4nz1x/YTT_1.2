// УП Практическая работа 1.2
// Задание 4. Напишите программу, вычисляющую среднюю температуру за год.
// Создайте двумерный рандомный массив temperature 12 на 30, в котором будет храниться температура для каждого дня месяца (предполагается, что в каждом месяце 30 дней).
// Сгенерируйте значения температур случайным образом(в рамках разумного).
// Для каждого месяца выведите среднюю температуру.
// Для этого напишите метод, который пройдется по массиву temperature и для каждого месяца вычислит среднюю температуру , в качестве результата метод должен вернуть массив средних температур.
// Полученный массив средних температур отсортируйте по возрастанию

namespace YTT_2_4
{
    internal class Program
    {
        public int[] Avarage (int[,] temperature)
        {
            int[] AvarageTemp = new int[temperature.GetLength(0)];
            int avarage = 0, sum = 0;
            for (int i = 0; i < temperature.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < temperature.GetLength(1); j++)
                {
                    sum += temperature[i, j];
                }

                avarage = sum / temperature.GetLength(1);
                AvarageTemp[i] = avarage;
            }
            
            return AvarageTemp;
        }
        public static void Main(string[] args)
        {
            Program Temp = new Program();
            Random random = new Random();
            int[,] temperature = new int[12, 30];
            int start = -35, end = -15;
            for (int i = 0; i < temperature.GetLength(0); i++)
            {

                for (int j = 0; j < temperature.GetLength(1); j++)
                {
                    temperature[i, j] = random.Next(start, end);
                }
                if (i < 6)
                {
                    start += 8;
                    end += 9;
                }
                else if (i < 12)
                {
                    start += -7;
                    end += -8;
                }
            }
            
            int[] AvarageTemp = Temp.Avarage(temperature);
            Array.Sort(AvarageTemp);
            Console.Write("Отсортированный массив средних температур: ");
            for (int i = 0; i < AvarageTemp.Length; i++)
            {
                Console.Write($"{AvarageTemp[i]} ");
            }

        }
    }
}