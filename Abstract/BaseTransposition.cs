using System;

namespace Transposition.Abstract
{
    public abstract class BaseTransposition
    {
        protected string Keyword {get; set;}
        protected string Alphabet  {get; set;}
        protected string Word  {get; set;}
        protected int Bit  {get; set;}
        public BaseTransposition(string Keyword, string Alphabet, string Word, int Bit)
        {
            this.Keyword = Keyword;
            this.Alphabet = Alphabet;
            this.Word = Word;
            this.Bit = Bit;
        }
        public abstract Dictionary<string, string> AddWordToDictionary();   
        public abstract void Display();
    }
}