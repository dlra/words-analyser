using System;
using System.Collections.Generic;
using System.Linq;

namespace WordsAnalyser.Services
{

    internal class ListPrintingService<T> : IListPrintingService<T>
    {
        protected IEnumerable<T> list;

        internal ListPrintingService(IEnumerable<T> list)
        {
            this.list = list;
        }

        public virtual void PrintItemInList(int position)
        {
            ValidatePositionInBounds(position);

            Console.WriteLine($"Word at position {position}: {list.ElementAt(position - 1)}");
        }

        public  void PrintItemFromEndInList(int positionFromEnd)
        {
            var count = list.Count();
            PrintItemInList(count - positionFromEnd + 1);
        }

        void ValidatePositionInBounds(int position)
        {
            if (position < 1 || position > list.Count())
            {
                Console.WriteLine("Index is out of range");
                return;
            }
        }
    }
}