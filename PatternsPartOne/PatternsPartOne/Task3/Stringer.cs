using System;

namespace PatternsPartOne.Task3
{
    public class Stringer
    {
        private string Sentence { get; set; } 

        public Stringer(string sentence)
        {
            Sentence = sentence;
        }

        public Stringer Upper()
        {
            Sentence = Sentence.ToUpper();
            return this;
        }

        public Stringer Lower()
        {
            Sentence = Sentence.ToLower();
            return this;
        }

        public Stringer Reverse()
        {
            char[] array = Sentence.ToCharArray();
            Array.Reverse(array);
            Sentence = new String(array);

            return this;
        }

        public Stringer Trim()
        {
            Sentence = Sentence.Trim();
            return this;
        }

        public Stringer RemoveSymbol(string symbol)
        {
            Sentence = Sentence.Replace(symbol, "");
            return this;
        }

        public string Result()
        {
            return Sentence;
        }
    }
}
