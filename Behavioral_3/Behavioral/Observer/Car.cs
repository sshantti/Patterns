using System;
using System.Collections.Generic;

namespace Behavioral.Observer
{
    public abstract class Car : ICarSubject
    {
        private List<ICarObserver> _observers = new List<ICarObserver>();
        private int _speed;
        private string _color;

        public string ModelName { get; protected set; }

        public Car(string modelName, int speed, string color)
        {
            ModelName = modelName;
            _speed = speed;
            _color = color;
        }

        public int Speed
        {
            get => _speed;
            set
            {
                if (_speed != value)
                {
                    int oldSpeed = _speed;
                    _speed = value;
                    Notify(nameof(Speed), oldSpeed, _speed);
                }
            }
        }

        public string Color
        {
            get => _color;
            set
            {
                if (_color != value)
                {
                    string oldColor = _color;
                    _color = value;
                    Notify(nameof(Color), oldColor, _color);
                }
            }
        }

        public void Attach(ICarObserver observer) => _observers.Add(observer);
        public void Detach(ICarObserver observer) => _observers.Remove(observer);

        protected void Notify(string propertyName, object oldValue, object newValue)
        {
            foreach (var observer in _observers)
            {
                observer.OnPropertyChanged(this, propertyName, oldValue, newValue);
            }
        }
    }

    // Наследники
    public class Sedan : Car { public Sedan(string model, int speed, string color) : base(model, speed, color) { } }
    public class SUV : Car { public SUV(string model, int speed, string color) : base(model, speed, color) { } }
}