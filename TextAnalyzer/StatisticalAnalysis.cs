using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TextAnalyzer
{
    public class StatisticalAnalysis
    {
        public int DictionarySize => _occurences.Count;

        public int Size => _occurences.Sum(x => x.Value);

        private Iterator _iterator;

        private View _view = new View();

        private Dictionary<string, int> _occurences = new Dictionary<string, int>();
        public StatisticalAnalysis(Iterator iterator)
        {
            _iterator = iterator;
            PopulateDictionaryWithOccurences();
        }

        private void PopulateDictionaryWithOccurences()
        {
            var occurence = Iterate();
            while (occurence != null)
            {
                try
                {
                    _occurences.Add(occurence, 1);
                }
                catch (ArgumentException)
                {
                    _occurences[occurence]++;
                }
                finally
                {
                    occurence = Iterate();
                }
            }
        }

        public void CountOf(params string[] elems)
        {
            int count = 0;
            foreach (var elem in elems)
            {
                try
                {
                    count = _occurences[elem];
                }
                catch (KeyNotFoundException)
                {
                    count = 0;
                }
                _view.Print($"'{elem}': {count}");
            }
        }

        public IEnumerable<string> OccurMoreThan(int startNumber) // ISet
        {
            var result = _occurences.Where(x => x.Value > startNumber)
                                        .Select(x => x.Key);
            return result;
        }

        private string Iterate()
        {
            if (_iterator.HasNext())
            {
               return _iterator.MoveNext();
            }

            return null;
        }
    }
}
