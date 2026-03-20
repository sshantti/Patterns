using System;

namespace Behavioral.Visitor
{
    public class VolumeVisitor : IVisitor
    {
        private const double SphereVolumeCoefficient = 4.0 / 3.0;
        private const double TorusVolumeCoefficient = 2.0;

        private const double Squared = 2.0;
        private const double Cubed = 3.0;
        public double TotalVolume { get; private set; } = 0;

        public void Visit(Sphere element)
        {
            // Формула: V = 4/3 * pi * r^3
            double volume = SphereVolumeCoefficient * Math.PI * Math.Pow(element.Radius, Cubed);
            Console.WriteLine($"Объем Сферы: {volume:F2}");
            TotalVolume += volume;
        }

        public void Visit(Parallelepiped element)
        {
            // Формула: V = a * b * c
            double volume = element.Width * element.Height * element.Length;
            Console.WriteLine($"Объем Параллелепипеда: {volume:F2}");
            TotalVolume += volume;
        }

        public void Visit(Torus element)
        {
            // Формула: V = 2 * pi^2 * R * r^2
            double volume = TorusVolumeCoefficient * Math.Pow(Math.PI, Squared) * element.MajorRadius * Math.Pow(element.MinorRadius, Squared);
            Console.WriteLine($"Объем Тора: {volume:F2}");
            TotalVolume += volume;
        }

        public void Visit(Cube element)
        {
            // Формула: V = a^3
            double volume = Math.Pow(element.Side, Cubed);
            Console.WriteLine($"Объем Куба: {volume:F2}");
            TotalVolume += volume;
        }
    }
}