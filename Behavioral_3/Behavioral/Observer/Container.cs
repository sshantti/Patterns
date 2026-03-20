using System;
using System.Collections.Generic;

namespace Behavioral.Observer
{
    public class Container : ICarObserver
    {
        private List<Car> _cars = [];

        public void AddCar(Car car)
        {
            _cars.Add(car);
            // Подписываемся на изменения свойств
            car.Attach(this);
            Console.WriteLine($"[Container]: В коллекцию добавлен экземпляр класса {car.GetType().Name} (Модель: {car.ModelName}).");
        }

        public void OnPropertyChanged(Car car, string propertyName, object oldValue, object newValue)
        {
            Console.WriteLine($"[Container]: У авто '{car.ModelName}' изменено свойство '{propertyName}'. Старое значение: {oldValue}, Новое значение: {newValue}");
        }
    }
}