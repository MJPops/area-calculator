using AreaCalculator.Models;
using System;

namespace AreaCalculator
{
    /// <summary>
    /// The class allows you to perform various calculations related to geometric shapes.
    /// </summary>
    public class AreasCalculator
    {
        /// <summary>
        /// Calculates the area of a circle.
        /// </summary>
        /// <exception cref="Exception"></exception>
        static public float GetArea(float radius)
        {
            Circle circle = new(radius);
            return circle.GetArea();
        }
        /// <summary>
        /// Calculates the area of a triangle.
        /// </summary>
        /// <exception cref="Exception"></exception>
        static public float GetArea(float firstSide, float secondSide, float thierdSide)
        {
            Triangle triangle = new(firstSide, secondSide, thierdSide);
            return triangle.GetArea();
        }
        /// <summary>
        /// Returns true if the triangle is a right triangle. Otherwise, it's false.
        /// </summary>
        /// <exception cref="Exception"></exception>
        static public bool IsRightTriangle(float firstSide, float secondSide, float thierdSide)
        {
            Triangle triangle = new(firstSide, secondSide, thierdSide);
            return triangle.IsRightTriangle();
        }
    }
}
