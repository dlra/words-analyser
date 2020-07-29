using System.Threading.Tasks;

namespace WordsAnalyser.Services
{
    interface ITextService
    {
        Task<string> GetText();
    }
}