using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Flyweight
{
    public interface IPublisher { void PrintDetails(string bookTitle); }

    public class Publisher : IPublisher
    {
        private string _name; // Общее состояние
        public Publisher(string name) { _name = name; }

        public void PrintDetails(string bookTitle)
        {
            Console.WriteLine($"Книга '{bookTitle}' издана в '{_name}'");
        }
    }

    public class PublisherFactory
    {
        private Dictionary<string, IPublisher> _publishers = new Dictionary<string, IPublisher>();

        public IPublisher GetPublisher(string name)
        {
            if (!_publishers.ContainsKey(name))
                _publishers[name] = new Publisher(name);
            return _publishers[name];
        }
    }
}