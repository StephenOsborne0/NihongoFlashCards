using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JapaneseLearning
{
    public partial class MainForm : Form
    {
        private static Random _random;

        private KanaType _selectedKanaType
        {
            get
            {
                if(katakanaRadioButton.Checked)
                    return KanaType.Katakana;

                if (hiraganaRadioButton.Checked)
                    return KanaType.Hiragana;

                if (kanjiRadioButton.Checked)
                    return KanaType.Kanji;

                throw new InvalidOperationException("How did you even get here?!");
            }
        } 

        private (string phonetic, string kana) CurrentKana { get; set; }
        private (string word, string kana, string kanji) CurrentKanji { get; set; }

        private int _correctCount = 0;
        private int _kanaCount = 0;

        public MainForm() => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e)
        {
            testGroupBox.Visible = testCheckbox.Checked;
            wordLabel.Visible = _selectedKanaType == KanaType.Kanji;
            _random = new Random();

            if(_selectedKanaType == KanaType.Katakana || _selectedKanaType == KanaType.Hiragana)
                GetNewKana(_selectedKanaType);
            else
                GetNewKanji();
        }

        private void GetNewKana(KanaType kanaType)
        {
            var extended = extendedKanaCheckbox.Checked;
            var kana = new List<(string phonetic, string kana)>();

            switch (kanaType)
            {
                case KanaType.Katakana:
                {
                    kana = extended ? Kana.GetExtendedKatakana() : Kana.GetBaseKatakana();
                    break;
                }

                case KanaType.Hiragana:
                {
                    kana = extended ? Kana.GetExtendedHiragana() : Kana.GetBaseHiragana();
                    break;
                }

                default:
                    throw new ArgumentOutOfRangeException(nameof(kanaType), kanaType, null);
            }

            var newKana = CurrentKana;

            while (newKana == CurrentKana)
                newKana = kana[_random.Next(0, kana.Count)];

            CurrentKana = newKana;
            UpdateCurrentKana();
        }

        private void GetNewKanji()
        {
            var kanji = new List<(string word, string kana, string kanji)>();
            //Add level switching etc later
            kanji = Kanji.GetKanjiLevel(10);

            var newKanji = CurrentKanji;

            while (newKanji == CurrentKanji)
                newKanji = kanji[_random.Next(0, kanji.Count)];

            CurrentKanji = newKanji;
            UpdateCurrentKana();
        }

        private void UpdateKanaCount() => _kanaCount++;

        private void UpdateCurrentKana()
        {
            if (_selectedKanaType == KanaType.Katakana || _selectedKanaType == KanaType.Hiragana)
            {
                kanaLabel.Text = CurrentKana.kana;
                phoneticLabel.Text = CurrentKana.phonetic;
            }
            else
            {
                kanaLabel.Text = CurrentKanji.kanji;
                phoneticLabel.Text = CurrentKanji.kana;
                wordLabel.Text = CurrentKanji.word;
            }
        }

        private void nextKanaButton_Click(object sender, EventArgs e)
        {
            if(testCheckbox.Checked)
            {
                bool kanaCorrect = _selectedKanaType == KanaType.Kanji ?
                    string.Equals(kanaAnswerTextBox.Text, CurrentKanji.kana, StringComparison.CurrentCultureIgnoreCase) :
                    string.Equals(kanaAnswerTextBox.Text, CurrentKana.phonetic, StringComparison.CurrentCultureIgnoreCase);

                bool meaningCorrect = _selectedKanaType != KanaType.Kanji || string.Equals(meaningAnswerTextBox.Text, CurrentKanji.word,
                                          StringComparison.CurrentCultureIgnoreCase);

                if (!kanaCorrect)
                    MessageBox.Show($"The correct kana is: {(_selectedKanaType == KanaType.Kanji ? CurrentKanji.kana : CurrentKana.phonetic)}");

                if (!meaningCorrect)
                    MessageBox.Show($"The correct meaning is: {CurrentKanji.word}");

                if (kanaCorrect && meaningCorrect)
                    _correctCount++;

                kanaAnswerTextBox.Text = string.Empty;
                meaningAnswerTextBox.Text = string.Empty;

                UpdateKanaCount();
                correctCountLabel.Text = $"{_correctCount} / {_kanaCount}";
            }

            if (_selectedKanaType == KanaType.Katakana || _selectedKanaType == KanaType.Hiragana)
                GetNewKana(_selectedKanaType);
            else
                GetNewKanji();
        }

        private enum KanaType
        {
            Katakana,
            Hiragana,
            Kanji
        }

        private void testCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            testGroupBox.Visible = testCheckbox.Checked;
            phoneticLabel.Visible = !testCheckbox.Checked;
            wordLabel.Visible = !testCheckbox.Checked && _selectedKanaType == KanaType.Kanji;
            meaningLabel.Visible = _selectedKanaType == KanaType.Kanji;
            meaningAnswerTextBox.Visible = _selectedKanaType == KanaType.Kanji;
        }

        private void katakanaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedKanaType == KanaType.Katakana)
                GetNewKana(_selectedKanaType);
        }

        private void hiraganaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedKanaType == KanaType.Hiragana)
                GetNewKana(_selectedKanaType);
        }

        private void kanjiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(_selectedKanaType == KanaType.Kanji)
                GetNewKanji();

            if (!testCheckbox.Checked)
                wordLabel.Visible = kanjiRadioButton.Checked;
            else
            {
                meaningLabel.Visible = _selectedKanaType == KanaType.Kanji;
                meaningAnswerTextBox.Visible = _selectedKanaType == KanaType.Kanji;
            }
        }
    }
}
