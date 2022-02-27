using AreaCalculator.Models;
using System;

namespace AreaCalculator
{
    public class AreasCalculator
    {
        public float GetArea(float radius)
        {
            Circle circle = new(radius);
            return circle.GetArea();
        }
        public float GetArea(float FirstSide, float SecondSide, float ThierdSide)
        {
            Triangle triangle = new(FirstSide, SecondSide, ThierdSide);
            return triangle.GetArea();
        }
        public bool IsRightTriangle(float FirstSide, float SecondSide, float ThierdSide)
        {
            Triangle triangle = new(FirstSide, SecondSide, ThierdSide);
            return triangle.IsRightTriangle();
        }
    }
}
