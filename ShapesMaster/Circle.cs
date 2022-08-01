using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesMaster
{
    internal class Circle : IShape
    {
        private double _radius;
        public double Radius
        {
            get => _radius;
            set
            {
                if (value > 0)
                    _radius = value;
                throw new ArgumentException("Radius must be greater than 0.");
            }
        }
        private double? _area;
        public double Area => _area ??= Math.PI * Math.Pow((double)Radius, 2);
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
