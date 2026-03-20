using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_1
{
    public class TransportClient
    {
        private Vehicle _vehicle;
        private Cargo _cargo;
        private Tank _tank;

        // Конструктор принимает любую фабрику
        public TransportClient(AbstractTransportFactory factory)
        {
            _vehicle = factory.CreateVehicle();
            _cargo = factory.CreateCargo();
            _tank = factory.CreateTank();
        }

        public void ShowGarage()
        {
            Console.WriteLine($"Автомобиль: {_vehicle.GetType().Name} (Скорость: {_vehicle.MaxSpeed} км/ч, Цвет: {_vehicle.Color})");
            Console.WriteLine($"Грузовик: {_cargo.GetType().Name} (Грузоподъемность: {_cargo.Tonnage} т, Осей: {_cargo.AxlesAmount})");
            Console.WriteLine($"Танк: {_tank.GetType().Name} (Калибр: {_tank.ProjectileCaliber} мм, Экипаж: {_tank.CrewSize} чел.)");
            Console.WriteLine("--------------------------------------------------");
        }
    }
}