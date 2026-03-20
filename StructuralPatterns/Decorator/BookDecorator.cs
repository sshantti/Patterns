using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    // Базовый класс декоратора следует тому же интерфейсу, что и другие компоненты. 
    public abstract class BookDecorator : IBook
    {
        protected IBook _book;
        public BookDecorator(IBook book) { _book = book; }
        public virtual string GetInfo() => _book.GetInfo();
    }
}
