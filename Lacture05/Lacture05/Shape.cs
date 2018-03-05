using System;
using System.Diagnostics;

namespace Lacture05
{
    public abstract class Shape
    {
        private readonly string name;

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double GetSquare();

        public override string ToString()
        => $"{this.name} has sqare of {this.GetSquare()}";
    }

    public class Square : Rect
    {
        public Square(string name, double sideLength)
            : base(name, sideLength, sideLength)
        {
        }
    }

    public class Circle : Shape
    {
        private readonly double radius;

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double GetSquare()
            => Math.PI * this.radius * this.radius;
    }

    public class Rect : Quadrilateral
    {
        public Rect(string name,
            double sideA,
            double sideB)
            : base(name, sideA, sideB, angle: 90)
        {
        }
    }

    public class Rombus : Parallelogram
    {
        public Rombus(string name, double side, double hight)
            : base(name, side, hight)
        {
        }
    }

    public class Parallelogram : Quadrilateral
    {
        public Parallelogram(string name,
            double baseSide,
            double hight) : base(name, baseSide, hight, angle: 90)
        {
        }
    }

    public class Quadrilateral : Shape
    {
        private readonly double sideA;
        private readonly double sideB;
        private readonly double angle;

        public Quadrilateral(
            string name,
            double sideA,
            double sideB,
            double angle)
            : base(name)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.angle = angle;
        }

        public override double GetSquare()
            => this.sideA * this.sideB * Math.Cos(angle);
    }


}
