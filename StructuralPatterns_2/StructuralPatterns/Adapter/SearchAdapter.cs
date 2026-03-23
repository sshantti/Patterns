namespace StructuralPatterns.Adapter
{
    internal class SearchAdapter : INewSearch
    {
        private readonly OldSearchSystem _oldSystem;

        public SearchAdapter(OldSearchSystem oldSystem)
        {
            this._oldSystem = oldSystem;
        }

        public string Search(string query)
        {
            // Адаптируем вызов
            return this._oldSystem.FindBookInLegacyDb(query);
        }
    }
}