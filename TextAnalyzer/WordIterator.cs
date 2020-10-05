using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyzer
{
    public class WordIterator : Iterator
    {
        private FileContent _fileContent;

        private int _currentIndex = 0;
        public WordIterator(FileContent fileContent)
        {
            _fileContent = fileContent;
        }
        public bool HasNext()
        {
            return _currentIndex < _fileContent.Words.Length;
        }

        public string MoveNext()
        {
            var result = _fileContent.Words[_currentIndex];
            _currentIndex++;
            return result;
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
