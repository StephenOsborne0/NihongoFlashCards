using System;
using System.Collections.Generic;
using System.Linq;

namespace JapaneseLearning
{
    public class Kanji
    {
        public static List<(string word, string kana, string kanji)> GetAllKanji()
        {
            var kanji = new List<(string word, string kana, string kanji)>();

            for(int i = 1; i <= 10; i++)
                kanji = kanji.Concat(GetKanjiLevel(i)).ToList();

            return kanji;
        }

        public static List<(string word, string kana, string kanji)> GetKanjiLevel(int level)
        {
            switch(level)
            {
                case 1: throw new NotImplementedException();
                case 2: throw new NotImplementedException();
                case 3: throw new NotImplementedException();
                case 4: throw new NotImplementedException();
                case 5: throw new NotImplementedException();
                case 6: throw new NotImplementedException();
                case 7: throw new NotImplementedException();
                case 8: throw new NotImplementedException();
                case 9: throw new NotImplementedException();
                case 10: return Level10Kanji.ToList();
                default: throw new ArgumentException(nameof(level));
            }
        }

        private static readonly (string word, string kana, string kanji)[] Level10Kanji =
        {
            ("Water", "mizu", "水"),
            ("Fire", "hi", "火"),
            ("I", "boku", "僕"),
            ("Flower", "hana", "花"),
        };
    }
}
