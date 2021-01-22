using System.Collections.Generic;
using System.Linq;

namespace JapaneseLearning
{
    public class Kana
    {
        public static List<(string phonetic, string kana)> GetBaseKatakana() => BaseKatakana.ToList();
        public static List<(string phonetic, string kana)> GetExtendedKatakana() => GetBaseKatakana().Concat(ExtendedKatakana.ToList()).ToList();
        public static List<(string phonetic, string kana)> GetBaseHiragana() => BaseHiragana.ToList();
        public static List<(string phonetic, string kana)> GetExtendedHiragana() => GetBaseHiragana().Concat(ExtendedHiragana.ToList()).ToList();

        private static readonly(string phonetic, string kana)[] BaseKatakana =
        {
            ("a", "ア"),
            ("i", "イ"),
            ("u", "ウ"),
            ("e", "エ"),
            ("o", "オ"),

            ("ma", "マ"),
            ("mi", "ミ"),
            ("mu", "ム"),
            ("me", "メ"),
            ("mo", "モ"),

            ("na", "ナ"),
            ("ni", "ニ"),
            ("nu", "ヌ"),
            ("ne", "ネ"),
            ("no", "ノ"),

            ("sa", "サ"),
            ("shi", "シ"),
            ("su", "ス"),
            ("se", "セ"),
            ("so", "ソ"),

            ("ta", "タ"),
            ("chi", "チ"),
            ("tsu", "ツ"),
            ("te", "テ"),
            ("to", "ト"),

            ("ka", "カ"),
            ("ki", "キ"),
            ("ku", "ク"),
            ("ke", "ケ"),
            ("ko", "コ"),

            ("ha", "ハ"),
            ("hi", "ヒ"),
            ("fu", "フ"),
            ("he", "ヘ"),
            ("ho", "ホ"),

            ("ra", "ラ"),
            ("ri", "リ"),
            ("ru", "ル"),
            ("re", "レ"),
            ("ro", "ロ"),

            ("wa", "ワ"),
            ("wo", "ヲ"),

            ("ya", "ヤ"),
            ("yu", "ユ"),
            ("yo", "ヨ")
        };

        private static readonly (string phonetic, string kana)[] ExtendedKatakana =
        {
            ("za", "ザ"),
            ("zi", "ジ"),
            ("zu", "ズ"),
            ("ze", "ゼ"),
            ("zo", "ゾ"),

            ("da", "ダ"),
            ("de", "デ"),
            ("do", "ド"),

            ("ga", "ガ"),
            ("gi", "ギ"),
            ("gu", "グ"),
            ("ge", "ゲ"),
            ("go", "ゴ"),

            ("ba", "バ"),
            ("bi", "ビ"),
            ("bu", "ブ"),
            ("be", "ベ"),
            ("bo", "ボ"),

            ("pa", "パ"),
            ("pi", "ピ"),
            ("pu", "プ"),
            ("pe", "ペ"),
            ("po", "ポ"),

            ("kya", "キャ"),
            ("kyu", "キュ"),
            ("kyo", "キョ"),

            ("gya", "ギャ"),
            ("gyu", "ギュ"),
            ("gyo", "ギョ"),

            ("nya", "ニャ"),
            ("nyu", "ニュ"),
            ("nyo", "ニョ"),

            ("hya", "ヒャ"),
            ("hyu", "ヒュ"),
            ("hyo", "ヒョ"),

            ("bya", "ビャ"),
            ("byu", "ビュ"),
            ("byo", "ビョ"),

            ("pya", "ピャ"),
            ("pyu", "ピュ"),
            ("pyo", "ピョ"),

            ("mya", "ミャ"),
            ("myu", "ミュ"),
            ("myo", "ミョ"),

            ("rya", "リャ"),
            ("ryu", "リュ"),
            ("ryo", "リョ"),

            ("ja", "ジャ"),
            ("ju", "ジュ"),
            ("je", "ジェ"),
            ("jo", "ジョ"),

            ("cha", "チャ"),
            ("chu", "チュ"),
            ("che", "チェ"),
            ("cho", "チョ"),

            ("sha", "シャ"),
            ("shu", "シュ"),
            ("she", "シェ"),
            ("sho", "ショ"),
        };

        private static readonly (string phonetic, string kana)[] BaseHiragana =
        {
            ("a", "あ"),
            ("i", "い"),
            ("u", "う"),
            ("e", "え"),
            ("o", "お"),

            ("ma", "ま"),
            ("mi", "み"),
            ("mu", "む"),
            ("me", "め"),
            ("mo", "も"),

            ("na", "な"),
            ("ni", "に"),
            ("nu", "ぬ"),
            ("ne", "ね"),
            ("no", "の"),

            ("sa", "さ"),
            ("shi", "し"),
            ("su", "す"),
            ("se", "せ"),
            ("so", "そ"),

            ("ta", "た"),
            ("chi", "ち"),
            ("tsu", "つ"),
            ("te", "て"),
            ("to", "と"),

            ("ka", "か"),
            ("ki", "き"),
            ("ku", "く"),
            ("ke", "け"),
            ("ko", "こ"),

            ("ha", "は"),
            ("hi", "ひ"),
            ("fu", "ふ"),
            ("he", "へ"),
            ("ho", "ほ"),

            ("ra", "ら"),
            ("ri", "り"),
            ("ru", "る"),
            ("re", "れ"),
            ("ro", "ろ"),

            ("wa", "わ"),
            ("wo", "を"),

            ("ya", "や"),
            ("yu", "ゆ"),
            ("yo", "よ")
        };

        private static readonly (string phonetic, string kana)[] ExtendedHiragana =
        {
            ("za", "ざ"),
            ("zi", "じ"),
            ("zu", "ず"),
            ("ze", "ぜ"),
            ("zo", "ぞ"),

            ("da", "だ"),
            ("de", "で"),
            ("do", "ど"),

            ("ga", "が"),
            ("gi", "ぎ"),
            ("gu", "ぐ"),
            ("ge", "げ"),
            ("go", "ご"),

            ("ba", "ば"),
            ("bi", "び"),
            ("bu", "ぶ"),
            ("be", "べ"),
            ("bo", "ぼ"),

            ("pa", "ぱ"),
            ("pi", "ぴ"),
            ("pu", "ぷ"),
            ("pe", "ぺ"),
            ("po", "ぽ"),

            ("kya", "きゃ"),
            ("kyu", "きゅ"),
            ("kyo", "きょ"),

            ("gya", "ぎゃ"),
            ("gyu", "ぎゅ"),
            ("gyo", "ぎょ"),

            ("nya", "にゃ"),
            ("nyu", "にゅ"),
            ("nyo", "にょ"),

            ("hya", "ひゃ"),
            ("hyu", "ひゅ"),
            ("hyo", "ひょ"),

            ("bya", "びゃ"),
            ("byu", "びゅ"),
            ("byo", "びょ"),

            ("pya", "ぴゃ"),
            ("pyu", "ぴゅ"),
            ("pyo", "ぴょ"),

            ("mya", "みゃ"),
            ("myu", "みゅ"),
            ("myo", "みょ"),

            ("rya", "りゃ"),
            ("ryu", "りゅ"),
            ("ryo", "りょ"),

            ("ja", "じゃ"),
            ("ju", "じゅ"),
            ("je", "じぇ"),
            ("jo", "じょ"),

            ("cha", "ちゃ"),
            ("chu", "ちゅ"),
            ("che", "ちぇ"),
            ("cho", "ちょ"),

            ("sha", "しゃ"),
            ("shu", "しゅ"),
            ("she", "しぇ"),
            ("sho", "しょ"),
        };
    }
}
