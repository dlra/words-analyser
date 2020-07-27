using System.Threading.Tasks;
using System.Linq;
using WordsAnalyser.Services;

namespace WordsAnalyser
{
    class Program
    {
        const int COUNT = 10;

        static async Task Main(string[] args)
        {
            var text = await TextService.GetText();
            var list = WordOccurenceProcessor.ConstructDictionary(text).ToList();

            list.Sort((a, b) => b.Value.CompareTo(a.Value));

            PrintingService.PrintPopularWordsToConsole(list, COUNT);
        }
    }
}