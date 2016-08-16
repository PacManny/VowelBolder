using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelizerApp
{
    class FormatVowelsBold
    {
        public string TurnVowelBold(string sentence)
        {
            string boldVowels = "";
            foreach (char letter in sentence)
            {
                boldVowels = FormatLetters(boldVowels, letter);
            }
            return FinalizeFormatting(boldVowels);
        }
        private string FormatLetters(string boldVowels, char letter)
        {
            Utilities check = new Utilities();

            if (!check.IsVowel(letter.ToString()))
            {
                boldVowels += ( letter );
            }
            else
            {
                boldVowels += (@"{\b " + letter + "}");
            }

            return boldVowels;
        }
        private string FinalizeFormatting(string boldVowels)
        {
            return (@"{\rtf1\ansi" + boldVowels + "}");
        }
    }
}
