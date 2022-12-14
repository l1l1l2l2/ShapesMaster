using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesMaster
{
    public class Circle : IShape
    {
        private double _radius;
        public double Radius
        {
            get => _radius;
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Radius must be greater than 0.");
                _radius = value;
                    
            }
        }
        public double Area => Math.PI * Math.Pow((double)Radius, 2);
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
