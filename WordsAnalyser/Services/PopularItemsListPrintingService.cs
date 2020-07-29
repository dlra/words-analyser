using System;
using System.Collections.Generic;
using System.Linq;

namespace WordsAnalyser.Services
{
    class PopularItemsListPrintingService : ListPrintingService<KeyValuePair<string, int>>, IPopularItemsListPrintingService
    {
        internal PopularItemsListPrintingService(IEnumerable<KeyValuePair<string, int>> list) : base(list)
        {
            this.list = list;
        }

        public void PrintPopularItems(int count)
        {
            Console.WriteLine($"The top {count} words appearing in the text, along with number of appearances, are:");
            for (var i = 0; i < count; i++)
            {
                var element = list.ElementAt(i);
                Console.WriteLine($"{i + 1}. {element.Key}\t{element.Value}");
            }
        }
    }
}