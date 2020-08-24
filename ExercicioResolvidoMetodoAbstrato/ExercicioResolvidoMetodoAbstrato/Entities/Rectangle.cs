using System;
using System.Collections.Generic;
using System.Text;
using ExercicioResolvidoMetodoAbstrato.Entities.Enums;

namespace ExercicioResolvidoMetodoAbstrato.Entities
{
    class Rectangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double witdh, double height, Color color) : base(color)
        {
            Width = witdh;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
            

    }
}
