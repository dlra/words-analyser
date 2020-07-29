using WordsAnalyser.Services;

namespace WordsAnalyser.Controllers
{
    class PrintWordsController
    {
        private readonly IListPrintingService<string> _listPrintingService;
        private readonly IPopularItemsListPrintingService _popularItemsListPrintingService;

        internal PrintWordsController(
            IListPrintingService<string> listPrintingService,
            IPopularItemsListPrintingService popularItemsListPrintingService)
        {
            _listPrintingService = listPrintingService;
            _popularItemsListPrintingService = popularItemsListPrintingService;
        }

        internal void PrintOrderedWords(int count)
        {
            for (var i = 0; i < count; i++)
            {
                _listPrintingService.PrintItemInList(i + 1);
            }
            for (var i = 0; i < count; i++)
            {
                _listPrintingService.PrintItemFromEndInList(i + 1);
            }
        }

        internal void PrintPopularWords(int count)
        {
            _popularItemsListPrintingService.PrintPopularItems(count);

            for (var i = 0; i < count; i++)
            {
                _popularItemsListPrintingService.PrintItemInList(i + 1);
            }
            for (var i = 0; i < count; i++)
            {
                _popularItemsListPrintingService.PrintItemFromEndInList(i + 1);
            }
        }
    }
}