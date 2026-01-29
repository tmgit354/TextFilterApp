using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilterApp
{
    public class TextFilter
    {
        private readonly List<ITextFilter> _filters;

        public TextFilter(IEnumerable<ITextFilter> filters)
        {
            // Add filters to the list
            _filters = filters.ToList();
        }

        public string ApplyFilters(string input)
        {
            foreach (var filter in _filters)
            {
                input = filter.Apply(input);
            }
            return input;
        }

        public void ReadAndApplyFiltersFromFile(string filePath)
        {
            string text = File.ReadAllText(filePath);
            string filteredText = ApplyFilters(text);
            Console.WriteLine(filteredText);
        }
    }
}
