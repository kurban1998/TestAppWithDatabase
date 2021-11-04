using System;


namespace CircleAreaCalculator
{
    public class AreaCalculator: IAreaCalculator
    {   
        /// <summary>
        /// Подсчет площади круга
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        /// <returns>Площадь круга</returns>
        public double CircleSquare(double radius)
        {
            if (radius > 0)
            {
                return Math.PI * Math.Pow(radius, 2);
            }
            else if (radius == 0)
            {
              return 0;
            }
            else
            {
              throw new ArgumentOutOfRangeException();
            }
        }
        /// <summary>
        /// Подсчет площади трапеции
        /// </summary>
        /// <param name="sideA">Сторона А - основание</param>
        /// <param name="sideB">Сторона В - основание</param>
        /// <param name="height">Высота</param>
        /// <returns>Площадь трапеции</returns>
        public double TrapezeSquare(double sideA, double sideB, double height)
        {
            if (sideA <= 0 || sideB <= 0 || height <= 0)
            {
                throw new ArgumentOutOfRangeException();
                
            }
            else
            {
                return (sideA + sideB) / 2 * height;
            }
        }
    }
}
