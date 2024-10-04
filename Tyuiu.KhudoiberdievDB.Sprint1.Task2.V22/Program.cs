using Tyuiu.KhudoiberdievDB.Sprint1.Task2.V22.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint1.Task2.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Худойбердиев Д. Б. | ИСПБ 24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                    *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
            Console.WriteLine("* Задание #2                                                                   *");
            Console.WriteLine("* Вариант #22                                                                  *");
            Console.WriteLine("* Выполнил: Худойбердиев Далер Бахритдинович | ИСПБ 24-1                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,      *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int x;
            int y;
            int z;

            Console.WriteLine("Введите значение числа x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение числа y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение числа z");
            z = Convert.ToInt32(Console.ReadLine());
            
          

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Среднее значение " + ds.CalculateAVGValue(x, y, z));
            Console.ReadLine();
        }
    }
}
