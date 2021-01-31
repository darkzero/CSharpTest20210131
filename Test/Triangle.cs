using System;
namespace Test
{
    public class Triangle : Sharp
    {
        override public string Name {
            get {
                if (!isTriangle)
                {
                    return "NotTriangle";
                }
                else if (sides[0] == sides[1] && sides[1] == sides[2])
                {
                    // equilateral
                    return "Triangle(equilateral)";
                }
                else if (sides[0] == sides[1] || sides[0] == sides[2] || sides[1] == sides[2])
                {
                    // isosceles
                    return "Triangle(isosceles)";
                }
                else
                {
                    // scalene
                    return "Triangle(scalene)";

                }
            }
        }

        override public double Perimeter
        {
            get
            {
                if (isTriangle)
                {
                    return sides[0] + sides[1] + sides[2];
                }
                else
                {
                    return 0.0;
                }
            }
        }

        override public double SurfaceArea
        {
            get
            {
                if (isTriangle)
                {
                    return Math.Sqrt(Perimeter / 2 * (Perimeter - sides[0]) * (Perimeter - sides[1]) * (Perimeter - sides[2]));
                }
                else
                {
                    return 0.0;
                }
            }
        }

        //
        double[] sides;
        private bool isTriangle;

        private Triangle(double[] _sides)
        {
            sides = _sides;
            Array.Sort(sides);
            if (sides.Length < 3 || sides[0] + sides[1] <= sides[2])
            {
                isTriangle = false;
            }
            else
            {
                isTriangle = true;
            }
        }

        public static Sharp create(double[] _sides)
        {
            return new Triangle(_sides);
        }
    }
}
