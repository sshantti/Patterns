using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_1
{
    // --- Конкретные Vehicles ---
    public class Audi : Vehicle
    {
        public Audi()
        {
            Weight = 1.5;
            Length = 4.5;
            MaxSpeed = 240;
            WheelDrive = "front";
            VehicleClass = "sedan";
            Color = "Black";
        }
    }

    public class Honda : Vehicle
    {
        public Honda()
        {
            Weight = 1.2;
            Length = 4.2;
            MaxSpeed = 200;
            WheelDrive = "front";
            VehicleClass = "hatchback";
            Color = "Red";
        }
    }

    public class Tesla : Vehicle
    {
        public Tesla()
        {
            Weight = 2.0;
            Length = 4.9;
            MaxSpeed = 260;
            WheelDrive = "back";
            VehicleClass = "sedan";
            Color = "White";
        }
    }

    // --- Конкретные Cargos ---
    public class Volvo : Cargo
    {
        public Volvo()
        {
            Weight = 8.0;
            Length = 7.0;
            MaxSpeed = 110;
            Tonnage = 20.0;
            TankVolume = 400;
            AxlesAmount = 4;
        }
    }

    public class Man : Cargo
    {
        public Man()
        {
            Weight = 7.5;
            Length = 6.8;
            MaxSpeed = 105;
            Tonnage = 18.0;
            TankVolume = 350;
            AxlesAmount = 3;
        }
    }

    public class Scania : Cargo
    {
        public Scania()
        {
            Weight = 9.0;
            Length = 7.5;
            MaxSpeed = 120;
            Tonnage = 25.0;
            TankVolume = 500;
            AxlesAmount = 4;
        }
    }

    // --- Конкретные Tanks ---
    public class Abrams : Tank
    {
        public Abrams()
        {
            Weight = 62.0;
            Length = 9.77;
            MaxSpeed = 67;
            ProjectileCaliber = 120;
            ShotsPerMinute = 6;
            CrewSize = 4;
        }
    }

    public class Merkava : Tank
    {
        public Merkava()
        {
            Weight = 65.0;
            Length = 9.04;
            MaxSpeed = 64;
            ProjectileCaliber = 120;
            ShotsPerMinute = 5;
            CrewSize = 4;
        }
    }

    public class Tiger : Tank
    {
        public Tiger()
        {
            Weight = 54.0;
            Length = 8.45;
            MaxSpeed = 45;
            ProjectileCaliber = 88;
            ShotsPerMinute = 8;
            CrewSize = 5;
        }
    }
}