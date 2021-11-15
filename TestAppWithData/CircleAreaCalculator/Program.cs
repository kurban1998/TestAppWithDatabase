using System;
using System.Runtime.InteropServices;

namespace CircleAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator calculator = new AreaCalculator();
            using (FiguresDbContext db = new FiguresDbContext())
            { 
                ConsoleKeyInfo key; // для записи нажатой клавиши
                do
                {
                    try
                    {
                        Console.WriteLine("Введите 'C' для поиска площади круга");
                        Console.WriteLine("Введите 'T' для поиска площади трапеции");
                        var selectedKey = Console.ReadLine().ToLower();
                        Console.WriteLine();

                        switch (selectedKey)
                        {
                            case "с": 
                                #region CircleSquare
                                Console.WriteLine("ПОДСЧЕТ ПЛОЩАДИ КРУГА");
                                Console.WriteLine("Введите радиус круга");
                                double radius = Convert.ToDouble(Console.ReadLine());

                                double resCS = calculator.CircleSquare(radius); // передаем параметр               
                                Console.WriteLine($"Площадь окружности = {resCS}");
                                // запись в БД
                                Circle c = new Circle { Radius = radius, Square = resCS };
                                db.Circles.Add(c);
                                db.SaveChanges();
                                #endregion
                                break;
                            case "т":
                                #region TrapezeSquare

                                Console.WriteLine("ПОДСЧЕТ ПЛОЩАДИ ТРАПЕЦИИ");
                                Console.WriteLine("Сторона А");
                                double sideA = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Сторона B");
                                double sideB = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Высота");
                                double height = Convert.ToDouble(Console.ReadLine());
                                double resTS = calculator.TrapezeSquare(sideA, sideB, height);
                                Console.WriteLine($"Площадь трапеции = {resTS}");
                                // запись в БД
                                Trapeze t = new Trapeze() { UpperBase = sideA, LowerBase = sideB, Height = height, TrapezeSquare = resTS };
                                db.Trapezes.Add(t);
                                db.SaveChanges();
                                #endregion
                                break;
                            default:
                                Console.WriteLine("Вы ничего не выбрали!");
                                break;
                        }
                    }
                    catch (Exception )
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
