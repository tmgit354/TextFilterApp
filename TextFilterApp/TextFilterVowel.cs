using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilterApp
{
    public class TextFilterVowel : ITextFilter
    {
        const string vowelstr = "aeiou";
        public string Apply(string input)
        {
            var words = input.Split(' ');
            var result = words.Where(word => !HasVowelInMiddle(word)).ToArray();
            return string.Join(" ", result);
        }

        private bool HasVowelInMiddle(string word)
        {
            int length = word.Length;
            if (length < 3) return false; // Ignore words of length less than 3

            int middleIndex = length / 2;
            char middleChar = word[middleIndex];

            if (length % 2 == 0) // Even length words have two middle characters
            {
                char middleChar2 = word[middleIndex - 1];
                return vowelstr.Contains(middleChar) || vowelstr.Contains(middleChar2);
            }
            else
            {
                return vowelstr.Contains(middleChar);
            }
        }
    }
}
