namespace StructuralPatterns.Adapter
{
    internal class OldSearchSystem
    {
        public string FindBookInLegacyDb(string title)
        {
            return $"Legacy Search: Найдена книга '{title}' в старой базе.";
        }
    }
}