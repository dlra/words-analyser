using System.Collections.Generic;

namespace WordsAnalyser.Services
{
    interface IPopularItemsListPrintingService : IListPrintingService<KeyValuePair<string, int>>
    {
        void PrintPopularItems(int count);
    }
}