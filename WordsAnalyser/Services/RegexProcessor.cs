using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using WordsAnalyser.Utilities;

namespace WordsAnalyser.Services
{
    class RegexProcessor
    {
        string text;
        string pattern;

        public IEnumerable<string> GetMatches()
        {
            return Regex.Matches(text, pattern).Select(x => x.Value);
        }

        internal RegexProcessor(string text, string pattern)
        {
            this.text = text;
            this.pattern = pattern;
        }

        internal RegexProcessor(string text, RegexCall regexCall)
        {
            this.text = text;

            switch (regexCall)
            {
                case RegexCall.Words:
                    pattern = Constant.REGEX_WORDS;
                    break;
                default:
                    break;
            }
        }
    }
}