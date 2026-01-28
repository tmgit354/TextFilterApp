using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilterApp
{
    public class TextFilterLength : ITextFilter
    {
        private readonly int _minLength;
        public TextFilterLength(int minLength = 3) // Default minimum length is 3
        {
            _minLength = minLength;
        }
        public string Apply(string input)
        {
            var words = input.Split(' ');
            var result = words.Where(word => word.Length >= _minLength).ToArray();
            return string.Join(" ", result);
        }
    }
}
