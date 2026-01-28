using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilterApp
{
    public class TextFilterLetter : ITextFilter
    {
        private readonly char _letterToRemove;

        public TextFilterLetter(char letterToRemove = 't') // Default letter to remove is 't'
        {
            _letterToRemove = letterToRemove;
        }
        public string Apply(string input)
        {
            var words = input.Split(' ');
            var result = words.Where(word => !word.Contains(_letterToRemove) && !word.Contains(char.ToUpper(_letterToRemove))).ToArray();
            return string.Join(" ", result);
        }
    }
}
