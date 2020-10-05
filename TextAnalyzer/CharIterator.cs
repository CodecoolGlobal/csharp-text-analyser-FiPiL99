using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyzer
{
    public class CharIterator : Iterator
    {
        private FileContent _fileContent;

        private int _currentIndex = 0;

        public CharIterator(FileContent fileContent)
        {
            _fileContent = fileContent;
        }
        public bool HasNext()
        {
            return _currentIndex < _fileContent.Chars.Length;
        }

        public string MoveNext()
        {
            string result = _fileContent.Chars[_currentIndex].ToString();
            _currentIndex++;
            return result;
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
