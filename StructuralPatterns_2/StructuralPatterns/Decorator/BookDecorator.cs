namespace StructuralPatterns.Decorator
{
    public abstract class BookDecorator : IBook
    {
        protected IBook _book;
        public BookDecorator(IBook book) { _book = book; }
        public virtual string GetInfo() => _book.GetInfo();
    }
}