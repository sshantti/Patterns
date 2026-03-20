using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_1
{
    // Абстрактный класс фабрики
    public abstract class AbstractTransportFactory
    {
        public abstract Vehicle CreateVehicle();
        public abstract Cargo CreateCargo();
        public abstract Tank CreateTank();
    }

    // Конкретная фабрика 1
    public class AlphaFactory : AbstractTransportFactory
    {
        public override Vehicle CreateVehicle() => new Audi();
        public override Cargo CreateCargo() => new Volvo();
        public override Tank CreateTank() => new Abrams();
    }

    // Конкретная фабрика 2
    public class BetaFactory : AbstractTransportFactory
    {
        public override Vehicle CreateVehicle() => new Honda();
        public override Cargo CreateCargo() => new Man();
        public override Tank CreateTank() => new Merkava();
    }

    // Конкретная фабрика 3
    public class GammaFactory : AbstractTransportFactory
    {
        public override Vehicle CreateVehicle() => new Tesla();
        public override Cargo CreateCargo() => new Scania();
        public override Tank CreateTank() => new Tiger();
    }
}