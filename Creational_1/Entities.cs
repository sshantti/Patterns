using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_1
{
    // Базовая сущность
    public abstract class Car
    {
        public double Weight { get; set; }
        public double Length { get; set; }
        public int MaxSpeed { get; set; }
    }

    // Абстрактные продукты
    public abstract class Vehicle : Car
    {
        public string WheelDrive { get; set; }
        public string VehicleClass { get; set; }
        public string Color { get; set; }
    }

    public abstract class Cargo : Car
    {
        public double Tonnage { get; set; }
        public double TankVolume { get; set; }
        public int AxlesAmount { get; set; }
    }

    public abstract class Tank : Car
    {
        public double ProjectileCaliber { get; set; }
        public int ShotsPerMinute { get; set; }
        public int CrewSize { get; set; }
    }
}
