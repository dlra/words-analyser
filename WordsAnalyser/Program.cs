using System;
using System.Linq;
using System.Threading.Tasks;
using WordsAnalyser.Services;
using WordsAnalyser.Controllers;

namespace WordsAnalyser
{
    class Program
    {
        const int COUNT = 10;
        const string URL = "https://archive.org/stream/LordOfTheRingsApocalypticProphecies/Lord%20of%20the%20Rings%20Apocalyptic%20Prophecies_djvu.txt";

        static async Task Main(string[] args)
        {
            var textController = new TextController(new TextService(URL));
            var text = await textController.GetText();

            if (text.Length == 0)
            {
                Console.WriteLine("No text loaded");
                return;
            }

            var wordOccurenceProcessor = new WordOccurenceProcessor(text);
            var list = wordOccurenceProcessor.ConstructDictionary().ToList();
            list.Sort((a, b) => b.Value.CompareTo(a.Value));

            var printWordsController = new PrintWordsController(
                new ListPrintingService<string>(list: new RegexProcessor(text, RegexCall.Words).GetMatches()),
                new PopularItemsListPrintingService(list));

            printWordsController.PrintOrderedWords(COUNT);
            printWordsController.PrintPopularWords(COUNT);
        }
    }
}