using System;


namespace SkrugaDBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CircleDbContext db = new CircleDbContext())
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Введите радиус круга");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        CircleSquare circle = new CircleSquare();
                        double res = circle.CircleSquare1(radius); // передаем параметр               
                        Console.WriteLine($"Площадь окружности = {res}");
                        // запись в БД
                        Circle c = new Circle{Radius = radius, Square = res};
                        db.Circles.Add(c);
                        db.SaveChanges();

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ошибка");
                    }
                }
           
            }

        }
    }
}
