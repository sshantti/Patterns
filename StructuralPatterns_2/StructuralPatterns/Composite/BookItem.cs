namespace StructuralPatterns.Composite
{
    class BookItem : LibraryComponent
    {
        public BookItem(string name) : base(name) { }
        public override string Display() => $"Книга: {_name}";
    }
}