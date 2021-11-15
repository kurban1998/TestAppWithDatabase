using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaCalculator
{
    interface IAreaCalculator
    {
        double CircleSquare(double radius);
        double TrapezeSquare(double UpperBase, double LowerBase, double height);
    }
}
