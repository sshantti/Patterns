using System;

namespace Behavioral.Visitor
{
    public class Sphere : IShape
    {
        public double Radius { get; }
        public Sphere(double radius) => Radius = radius;
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }

    public class Parallelepiped : IShape
    {
        public double Width { get; }
        public double Height { get; }
        public double Length { get; }
        public Parallelepiped(double width, double height, double length)
        {
            Width = width; Height = height; Length = length;
        }
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }

    public class Torus : IShape
    {
        public double MajorRadius { get; } // R
        public double MinorRadius { get; } // r
        public Torus(double majorRadius, double minorRadius)
        {
            MajorRadius = majorRadius; MinorRadius = minorRadius;
        }
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }

    public class Cube : IShape
    {
        public double Side { get; }
        public Cube(double side) => Side = side;
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}