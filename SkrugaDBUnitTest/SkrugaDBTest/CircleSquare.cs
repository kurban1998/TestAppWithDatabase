using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkrugaDBTest
{
    public class CircleSquare
    {
        public double CircleSquare1(double radius)
        {
            if (radius > 0)
            {
                return Math.PI * Math.Pow(radius, 2);
            }
            else
                return 0;

        }
    }
}
