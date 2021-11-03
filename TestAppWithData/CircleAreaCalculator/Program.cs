using System;
using System.Runtime.InteropServices;

namespace CircleAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator circle = new AreaCalculator();
            AreaCalculator trapeze = new AreaCalculator();
            using (FiguresDbContext db = new FiguresDbContext())
            {
                ConsoleKeyInfo key; // для записи нажатой клавиши
                do
                {
                    try
                    {
                        Console.WriteLine("Нажмите 'C' для поиска площади круга");
                        Console.WriteLine("Нажмите 'T' для поиска площади трапеции");
                        var key1 = Console.ReadKey();
                        Console.WriteLine();

                        if (key1.Key == ConsoleKey.C)
                        {
                            #region CircleSquare
                            Console.WriteLine("ПОДСЧЕТ ПЛОЩАДИ КРУГА");
                            Console.WriteLine("Введите радиус круга");
                            double radius = Convert.ToDouble(Console.ReadLine());

                            double res = circle.CircleSquare(radius); // передаем параметр               
                            Console.WriteLine($"Площадь окружности = {res}");
                            // запись в БД
                            Circle c = new Circle { Radius = radius, Square = res };
                            db.Circles.Add(c);
                            db.SaveChanges();
                            #endregion
                        }
                        else if (key1.Key == ConsoleKey.T || key1.Key ==ConsoleKey.N)
                        {
                            #region TrapezeSquare

                            Console.WriteLine("ПОДСЧЕТ ПЛОЩАДИ ТРАПЕЦИИ");
                            Console.WriteLine("Сторона А");
                            double sideA = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Сторона B");
                            double sideB = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Высота");
                            double height = Convert.ToDouble(Console.ReadLine());
                            double res = trapeze.TrapezeSquare(sideA, sideB, height);
                            Console.WriteLine($"Площадь трапеции = {res}");
                            // запись в БД
                            Trapeze t = new Trapeze() { SideA = sideA, SideB = sideB, Height = height, TrapezeSquare = res };
                            db.Trapezes.Add(t);
                            db.SaveChanges();
                            #endregion
                        }
                        else
                        {
                            Console.WriteLine("Вы ничего не выбрали!");
                        }
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
