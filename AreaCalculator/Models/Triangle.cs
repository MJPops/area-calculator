using AreaCalculator.Interfaces;
using System;
using System.Linq;

namespace AreaCalculator.Models
{
    internal class Triangle : IBasicShapeOperations
    {
        private float[] SidesOfTriangle = new float[3];

        public Triangle(float FirstSide, float SecondSide, float ThierdSide)
        {
            SidesOfTriangle[0] = FirstSide;
            SidesOfTriangle[1] = SecondSide;
            SidesOfTriangle[2] = ThierdSide;

            if (SidesOfTriangle.Where(s => s < 0).Any())
            {
                throw new Exception("The side of the triangle must be greater than or equal to zero");
            }
            if (!TriangleIsValid())
            {
                throw new Exception("The sum of two sides of a triangle cannot be greater than the third");
            }
        }

        public float GetArea()
        {
            float halfPerimeter = SidesOfTriangle.Sum() / 2;
            return (float)Math.Sqrt(halfPerimeter * (halfPerimeter - SidesOfTriangle[0]) *
                (halfPerimeter - SidesOfTriangle[1]) *
                (halfPerimeter - SidesOfTriangle[2]));
        }
        public bool IsRightTriangle()
        {
            SidesOfTriangle = SidesOfTriangle.OrderBy(s => s).ToArray();

            if (SidesOfTriangle[2] * SidesOfTriangle[2] == SidesOfTriangle[0] * SidesOfTriangle[0] +
                SidesOfTriangle[1] * SidesOfTriangle[1])
            {
                return true;
            }
            return false;
        }


        private bool TriangleIsValid()
        {
            if (SidesOfTriangle[0] + SidesOfTriangle[1] < SidesOfTriangle[2] ||
                SidesOfTriangle[0] + SidesOfTriangle[2] < SidesOfTriangle[1] ||
                SidesOfTriangle[1] + SidesOfTriangle[2] < SidesOfTriangle[0])
            {
                return false;
            }
            return true;
        }
    }
}
