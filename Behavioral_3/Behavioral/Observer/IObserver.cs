namespace Behavioral.Observer
{
    public interface ICarObserver
    {
        void OnPropertyChanged(Car car, string propertyName, object oldValue, object newValue);
    }
}