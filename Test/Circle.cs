using System;
namespace Test
{
    public class Circle : Sharp
    {
        override public string Name
        {
            get
            {
                return "Circle";
            }
        }

        override public double Perimeter
        {
            get
            {
                return Math.PI * this.Radius * 2.0;
            }
        }

        override public double SurfaceArea {
            get
            {
                return Math.PI * this.Radius * this.Radius;
            }
        }

        //
        private double Radius;

        private Circle(double r)
        {
            Radius = r;
        }

        public static Sharp create(double r)
        {
            return new Circle(r);
        }
    }
}
