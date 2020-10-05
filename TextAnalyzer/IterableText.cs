using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyzer
{
    public interface IterableText
    {
        Iterator CharIterator();
        Iterator WordIterator();
    }
}
