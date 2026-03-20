using StructuralPatterns.Adapter;
using StructuralPatterns.Composite;
using StructuralPatterns.Decorator;
using StructuralPatterns.Facade;
using StructuralPatterns.Flyweight;
using StructuralPatterns.Proxy;


Console.WriteLine("=== 1. ADAPTER ===");
OldSearchSystem legacySearch = new OldSearchSystem();
INewSearch searchAdapter = new SearchAdapter(legacySearch);
Console.WriteLine(searchAdapter.Search("Дюна"));

Console.WriteLine("\n=== 2. COMPOSITE ===");
BookCategory fiction = new BookCategory("Фантастика");
BookCategory spaceOpera = new BookCategory("Космоопера");
spaceOpera.Add(new BookItem("Дюна"));
fiction.Add(spaceOpera);
fiction.Add(new BookItem("Нейромант"));
Console.WriteLine(fiction.Display());

Console.WriteLine("\n=== 3. DECORATOR ===");
IBook myBook = new ConcreteBook("1984");
myBook = new RatingDecorator(myBook, 5);
myBook = new ReadStatusDecorator(myBook, true);
Console.WriteLine(myBook.GetInfo());

Console.WriteLine("\n=== 4. FACADE ===");
LibraryFacade facade = new LibraryFacade();
Console.WriteLine(facade.CheckoutBook("Иван", "Властелин Колец"));

Console.WriteLine("\n=== 5. FLYWEIGHT ===");
PublisherFactory factory = new PublisherFactory();
IPublisher exmo1 = factory.GetPublisher("Эксмо");
exmo1.PrintDetails("Преступление и наказание");
IPublisher exmo2 = factory.GetPublisher("Эксмо");
Console.WriteLine($"Один и тот же объект издательства? {object.ReferenceEquals(exmo1, exmo2)}");

Console.WriteLine("\n=== 6. PROXY ===");
ILibraryAdmin adminProxy = new AdminProxy(Role.Student);
adminProxy.DeleteBook("Мастер и Маргарита"); // Отказ

ILibraryAdmin trueAdmin = new AdminProxy(Role.Admin);
trueAdmin.DeleteBook("Справочник по C++"); // Успех
