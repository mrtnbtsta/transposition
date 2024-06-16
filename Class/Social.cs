using System;
using System.Text;
using Transposition.Abstract;

namespace Class.Transposition
{
    public class Social(string Keyword, string Alphabet, string Word, int Bit) : BaseTransposition(Keyword, Alphabet, Word, Bit)
    {
        int current = 0;
        
        public Dictionary<string, string>? Dict = [];

        public override Dictionary<string, string> AddWordToDictionary()
        {
            var newBit = 0;
            var output = "";
            for(var i = 0; i < Keyword.Length; i++)
            {
                if(i == 0)
                {
                    current = 0;
                    newBit = Bit;
                }
                else
                {
                    current = Bit * i;
                    newBit = Bit * i + Bit;
                }
                while(current < newBit)
                {
                    output += Word[current];
                    current++;
                }
                Dict!.TryAdd(Convert.ToString(Keyword[i]), output);
                output = "";
         
            }
            return Dict!;
        }

        public override void Display()
        {
            for(var i = 0; i < Keyword.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{Keyword[i]}\t");
            }
            Console.WriteLine();
            foreach(var rowDict in AddWordToDictionary())
            {
                foreach(var colDict in rowDict.Value)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{colDict}\t");
                }
                Console.WriteLine();
            }
        }
    }
}