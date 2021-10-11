using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaCalculatorNew
{
    public class AreaCalculator
    {
        public double CircleSquare1(double radius)
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
    }
}
