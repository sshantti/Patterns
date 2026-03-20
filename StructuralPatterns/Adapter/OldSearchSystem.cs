using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
