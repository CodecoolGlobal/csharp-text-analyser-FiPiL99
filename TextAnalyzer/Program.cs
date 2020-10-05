using System;

namespace TextAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileContent1 = new FileContent("test.txt");
            var charIterator = fileContent1.CharIterator();
            var charAnalysis = new StatisticalAnalysis(charIterator);
            charAnalysis.CountOf("s", "x", "");
            var size = charAnalysis.Size;
            var occureMoreThan4 = charAnalysis.OccurMoreThan(4);
        }
    }
}
