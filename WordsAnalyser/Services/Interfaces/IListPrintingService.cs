namespace WordsAnalyser.Services
{
    interface IListPrintingService<T>
    {
        void PrintItemInList(int position);
        void PrintItemFromEndInList(int position);
    }
}