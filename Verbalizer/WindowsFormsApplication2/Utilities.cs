using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelizerApp
{
    class Utilities
    {
        public bool IsVowel(string letter)
        {
            List<string> vowels = new List<string> { "A", "E", "I", "O", "U" };
            return vowels.Contains(letter.ToUpper());
        }
    }
}
