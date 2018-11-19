using System;
using System.Globalization;

namespace Course.Model.Entities
{
    class Circle: AbstractShape
    {

        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return string.Concat(
                "Circle color = "
                ,Color
                , ", Radius = "
                ,Radius.ToString("F2",CultureInfo.InvariantCulture)
                , ", Area = "
                , Radius.ToString("F2", CultureInfo.InvariantCulture)
                );
        }
    }
}
