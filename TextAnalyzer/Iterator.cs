using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyzer
{
    public interface Iterator
    {
        public bool HasNext();
        public string MoveNext();
        public void Remove();
    }
}
