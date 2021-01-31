using System;
namespace Test
{
    public class Quadrilateral: Sharp
    {
        override public string Name
        {
            get
            {
                if (sides[0] == sides[1])
                {
                    // equilateral
                    return "Square";
                }
                else
                {
                    // scalene
                    return "Rectangle";

                }
            }
        }

        override public double Perimeter
        {
            get
            {
                return (sides[0] + sides[1]) * 2.0;
            }
        }

        override public double SurfaceArea
        {
            get
            {
                return sides[0] * sides[1];
            }
        }

        double[] sides;

        private Quadrilateral(double[] _sides)
        {
            sides = _sides;
        }

        public static Sharp create(double[] _sides)
        {
            return new Quadrilateral(_sides);
        }
    }
}
