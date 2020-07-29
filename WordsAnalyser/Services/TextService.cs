using System;
using System.Threading.Tasks;
using System.Net.Http;
using WordsAnalyser.Utilities;

namespace WordsAnalyser.Services
{
    internal class TextService : ITextService
    {
        string url;

        internal TextService(string url)
        {
            this.url = url;
        }

        public async Task<string> GetText()
        {
            var client = new HttpClient();
            string webPage;
            
            try
            {
                webPage = await client.GetStringAsync(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return string.Empty;
            }

            var text = webPage?.ExtractInnerHtmlFromUniqueElement("pre");
            
            return text;
        }
    }
}