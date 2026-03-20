using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite
{
    // Конечный компонент
    class BookItem : LibraryComponent
    {
        public BookItem(string name) : base(name) { }
        public override string Display() => $"Книга: {_name}";
    }
}
