using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite
{
    // Композит
    class BookCategory : LibraryComponent
    {
        List<LibraryComponent> _children = new List<LibraryComponent>();
        public BookCategory(string name) : base(name) { }

        public override void Add(LibraryComponent component) => _children.Add(component);
        public override void Remove(LibraryComponent component) => _children.Remove(component);

        public override string Display()
        {
            string result = $"Категория '{_name}' содержит:\n";
            foreach (var c in _children)
            {
                result += "  " + c.Display() + "\n";
            }
            return result.TrimEnd();
        }
    }
}
