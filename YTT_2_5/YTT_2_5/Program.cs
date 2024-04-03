// УП Практическая работа 1.2
// Задание 5. Выполните задание 4, используя Dictionary<key, value>.
// В качестве ключей используйте названия месяцев, а в качестве значений – массив температур по дням.
// Напишите метод, который используя данные из словаря вычислит среднюю температуру для каждого месяца, и вернет словарь(Dictionary) средних температур (В качестве ключа название месяца, в качестве значения коллекция средних температура)

namespace YTT_2_5
{
    internal class Program
    {
        void Avarage (Dictionary<string, int[]> temperature)
        {
            Dictionary<string, int> avarageTemp = new Dictionary<string, int>();
            int avarage, sum;
            foreach (var n in temperature)
            {
                sum = 0;
                for (int i = 0; i < n.Value.Length; i++)
                {
                    sum += n.Value[i];
                }

                avarage = sum / n.Value.Length;
                avarageTemp.Add(n.Key, avarage);
            }
            Console.WriteLine("Средняя температура для каждого месяца:");
            foreach (var n in avarageTemp)
            {
                Console.WriteLine($"{n.Key}: {n.Value}");
            }

        }
        
        public static void Main(string[] args)
        {
            Program temp = new Program();
            Random random = new Random();
            Dictionary<string, int[]> temperature = new Dictionary<string, int[]> {};
            string[] month = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            int start = -35, end = -15;
            for (int i = 0; i < month.Length; i++)
            {
                int[] wheather = new int[30];
                for (int j = 0; j < wheather.Length; j++)
                {
                    wheather[j] = random.Next(start, end);
                }
                temperature.Add(month[i], wheather);
                if (i < 6)
                {
                    start += 9;
                    end += 10;
                }
                else if (i < 12)
                {
                    start += -8;
                    end += -9;
                }
            }
            
            temp.Avarage(temperature);
        }
    }
}