using System.Threading.Tasks;
using WordsAnalyser.Services;

namespace WordsAnalyser.Controllers
{
    class TextController
    {
        private readonly ITextService _textService;

        internal TextController(ITextService textService)
        {
            _textService = textService;
        }

        internal Task<string> GetText()
        {
            return _textService.GetText();
        }
    }
}