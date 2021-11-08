using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaCalculator
{
    /// <summary>
    /// Трапеция
    /// </summary>
    public class Trapeze
    {
        public int Id { get; set; }
        /// <summary>
        /// Сторона А - основание
        /// </summary>
        public double UpperBase { get; set; }
        /// <summary>
        /// Сторона B - основание
        /// </summary>
        public double LowerBase { get; set; }
        public double Height { get; set; }
        public double TrapezeSquare { get; set; }
    }
}
