using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using WordsAnalyser.Utilities;

namespace WordsAnalyser.Services
{
    internal class WordOccurenceProcessor : IWordOccurenceProcessor
    {
        string text;

        internal WordOccurenceProcessor(string text)
        {
            this.text = text;
        }

        public Dictionary<string, int> ConstructDictionary()
        {
            var regexProcessor = new RegexProcessor(text, Constant.REGEX_WORDS);
            var wordsOccurencesDictionary = new Dictionary<string, int>();

            foreach (var match in regexProcessor.GetMatches())
            {
                if (wordsOccurencesDictionary.ContainsKey(match))
                {
                    wordsOccurencesDictionary[match]++;
                }
                else
                {
                    wordsOccurencesDictionary.Add(match, 1);
                }
            }

            return wordsOccurencesDictionary;
        }
    }
}