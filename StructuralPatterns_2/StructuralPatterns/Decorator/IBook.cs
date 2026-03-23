namespace StructuralPatterns.Decorator
{
    public interface IBook { string GetInfo(); }

    public class ConcreteBook : IBook
    {
        private string _title;
        public ConcreteBook(string title) { _title = title; }
        public string GetInfo() => $"Книга: {_title}";
    }
}