using System;
using System.Collections.Generic;
using System.Linq;

namespace WordsAnalyser.Services
{
    static class PrintingService
    {
        internal static void PrintPopularWordsToConsole(IEnumerable<KeyValuePair<string, int>> list, int count)
        {
            Console.WriteLine($"The top {count} words appearing in the text, along with number of appearances, are:");
            for (var i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}.\t{list.ElementAt(i).Key}\t{list.ElementAt(i).Value}");
            }
        }
    }
}