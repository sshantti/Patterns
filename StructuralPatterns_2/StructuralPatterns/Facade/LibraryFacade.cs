namespace StructuralPatterns.Facade
{
    class LibraryFacade
    {
        private CatalogSystem _catalog;
        private BorrowingSystem _borrowing;

        public LibraryFacade()
        {
            _catalog = new CatalogSystem();
            _borrowing = new BorrowingSystem();
        }

        public string CheckoutBook(string user, string bookTitle)
        {
            string process = "Оформление книги:\n";
            process += _catalog.CheckAvailability(bookTitle) + "\n";
            process += _borrowing.ProcessCheckout(user, bookTitle);
            return process;
        }
    }

    class CatalogSystem { public string CheckAvailability(string book) => $"Каталог: Книга '{book}' в наличии."; }
    class BorrowingSystem { public string ProcessCheckout(string user, string book) => $"Оформление: Книга '{book}' выдана пользователю {user}."; }
}