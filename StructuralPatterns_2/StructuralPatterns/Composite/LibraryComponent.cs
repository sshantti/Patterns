namespace StructuralPatterns.Composite
{
    abstract class LibraryComponent
    {
        protected string _name;
        public LibraryComponent(string name) { _name = name; }
        public abstract string Display();
        public virtual void Add(LibraryComponent component) { }
        public virtual void Remove(LibraryComponent component) { }
    }
}