using System.Collections.Generic;

namespace WordsAnalyser.Services
{
    interface IWordOccurenceProcessor
    {
        Dictionary<string, int> ConstructDictionary();
    }
}