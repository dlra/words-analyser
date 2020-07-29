using System;

namespace WordsAnalyser.Utilities
{
    static class Extensions
    {
        internal static string ExtractInnerHtmlFromUniqueElement(this string @str, string element)
        {
            return @str.Split(new[] { $"<{element}>", $"</{element}>" }, StringSplitOptions.RemoveEmptyEntries)[1];
        }
    }
}
