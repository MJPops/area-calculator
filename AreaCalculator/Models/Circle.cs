using AreaCalculator.Interfaces;
using System;

namespace AreaCalculator.Models
{
    internal class Circle : IBasicShapeOperations
    {
        private float Radius { get; set; }

        internal Circle(float radius)
        {
            if (radius < 0)
            {
                throw new Exception("The radius must be greater than or equal to zero");
            }
            else
            {
                Radius = radius;
            }
        }

        public float GetArea()
        {
            return (float)(Math.PI * Radius * Radius);
        }
    }
}
