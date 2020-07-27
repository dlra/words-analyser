using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordsAnalyser.Services
{
    static class WordOccurenceProcessor
    {
        const string PATTERN = "\\w+";

        internal static Dictionary<string, int> ConstructDictionary(string text)
        {
            var matches = Regex.Matches(text, PATTERN);
            var wordsOccurencesDictionary = new Dictionary<string, int>();

            foreach (Match match in matches)
            {
                if (wordsOccurencesDictionary.ContainsKey(match.Value))
                {
                    wordsOccurencesDictionary[match.Value]++;
                }
                else
                {
                    wordsOccurencesDictionary.Add(match.Value, 1);
                }
            }

            return wordsOccurencesDictionary;
        }
    }
}