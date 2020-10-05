using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TextAnalyzer
{
    public class FileContent : IterableText
    {
        public string Text { get; }
        public string[] Words { get; }
        public string Chars { get; }
        public string FileName { get; }
        public FileContent(string filename)
        {
            try
            {
                Text = System.IO.File.ReadAllText(filename);
                FileName = filename;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Wrong filename");
            }

            Words = Text.Replace("\r\n", " ").Replace("  ", "").ToLower().Split(" ");
            Chars = Text.Replace("\r\n", "").Replace(" ", "").ToLower();
        }
        public Iterator CharIterator()
        {
            return new CharIterator(this);
        }

        public Iterator WordIterator()
        {
            return new WordIterator(this);
        }

        public string GetFileName()
        {
            throw new NotImplementedException();
        }
    }
}
