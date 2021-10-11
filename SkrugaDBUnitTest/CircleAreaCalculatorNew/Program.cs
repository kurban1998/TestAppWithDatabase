using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaCalculatorNew
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CircleDbContext db = new CircleDbContext())
            {
                ConsoleKeyInfo key; // для записи нажатой клавиши
                do
                {

                    try
                    {
                        Console.WriteLine("Введите радиус круга");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        AreaCalculator circle = new AreaCalculator();
                        double res = circle.CircleSquare1(radius); // передаем параметр               
                        Console.WriteLine($"Площадь окружности = {res}");
                        // запись в БД
                        Circle c = new Circle { Radius = radius, Square = res };
                        db.Circles.Add(c);
                        db.SaveChanges();

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Некорректный ввод");
                    }
                  Console.WriteLine("Для выхода нажмите Esc\r\nДля продолжения любую другую кнопку");
                  key = Console.ReadKey();// чтение
                  Console.WriteLine();
                } 
                while (key.Key != ConsoleKey.Escape); // пока не нажмем Esc
            }
        }
    }
}
