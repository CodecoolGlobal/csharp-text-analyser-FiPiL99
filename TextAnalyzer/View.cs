using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAnalyzer
{
    public class View
    {
        public void Print(string textToPrint)
        {
            Console.WriteLine(textToPrint);
        }

        public void Print(List<string> ListToPrint)
        {
            foreach (var text in ListToPrint)
            {
                Print(text);
            }
        }

        public void Print(Dictionary<string, int> dictToPrint)
        {
            var lines = dictToPrint.Select(kvp => kvp.Key + ": " + kvp.Value.ToString());
            foreach (var line in lines)
            {
                Print(line);
            }
        }
    }
}
