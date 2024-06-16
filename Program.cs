using System;
using System.Linq;
using Class.Transposition;
using Transposition.Abstract;

namespace Transposition
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            BaseTransposition KnightKeyword = new Knight("KNIGHT", ALPHABET, "THEFUTUREISBRIGHTWHENPEOPLEWORKTOGETHERX", 6);
            KnightKeyword.Display();
            Console.WriteLine("\n");
            BaseTransposition SocialKeyword = new Social("SOCIAL", ALPHABET, "ATTHEENDOFHARDSHIPCOMESHAPPINESSNWJS", 6);
            SocialKeyword.Display();
            Console.WriteLine("\n");
            BaseTransposition TurkeyKeyword = new Social("TURKEY", ALPHABET, "ICLOSEMYEYESANDTHEFLASHBACKSTARTSOMG", 6);
            TurkeyKeyword.Display();
            Console.WriteLine("\n");
            BaseTransposition OrangeKeyword = new Orange("ORANGE", ALPHABET, "ANAPPLEADAYKEEPSTHEDOCTORAWAYT", 6);
            OrangeKeyword.Display();
            Console.WriteLine("\n");
            BaseTransposition FranceKeyword = new France("FRANCE", ALPHABET, "SECRETMESSAGEFORYOUREYESONLYPS", 6);
            FranceKeyword.Display();
        }
    }
}