using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace WordsAnalyser.Services
{
    static class TextService
    {
        const string URL = "https://archive.org/stream/LordOfTheRingsApocalypticProphecies/Lord%20of%20the%20Rings%20Apocalyptic%20Prophecies_djvu.txt";

        internal static async Task<string> GetText()
        {
            var client = new HttpClient();
            var webPage = await client.GetStringAsync(URL);
            var text = webPage
                .Split(new[] { "<pre>", "</pre>" }, StringSplitOptions.RemoveEmptyEntries)[1];
            
            return text;
        }
    }
}