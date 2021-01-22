namespace JapaneseLearning
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kanaLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.testGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.meaningLabel = new System.Windows.Forms.Label();
            this.meaningAnswerTextBox = new System.Windows.Forms.TextBox();
            this.correctCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kanaAnswerTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kanjiRadioButton = new System.Windows.Forms.RadioButton();
            this.extendedKanaCheckbox = new System.Windows.Forms.CheckBox();
            this.testCheckbox = new System.Windows.Forms.CheckBox();
            this.hiraganaRadioButton = new System.Windows.Forms.RadioButton();
            this.katakanaRadioButton = new System.Windows.Forms.RadioButton();
            this.nextKanaButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wordLabel = new System.Windows.Forms.Label();
            this.phoneticLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.testGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kanaLabel
            // 
            this.kanaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kanaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kanaLabel.Location = new System.Drawing.Point(3, 16);
            this.kanaLabel.Name = "kanaLabel";
            this.kanaLabel.Size = new System.Drawing.Size(194, 181);
            this.kanaLabel.TabIndex = 0;
            this.kanaLabel.Text = "ka";
            this.kanaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 270);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.testGroupBox);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.nextKanaButton);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(541, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kana";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // testGroupBox
            // 
            this.testGroupBox.Controls.Add(this.label3);
            this.testGroupBox.Controls.Add(this.meaningLabel);
            this.testGroupBox.Controls.Add(this.meaningAnswerTextBox);
            this.testGroupBox.Controls.Add(this.correctCountLabel);
            this.testGroupBox.Controls.Add(this.label2);
            this.testGroupBox.Controls.Add(this.kanaAnswerTextBox);
            this.testGroupBox.Location = new System.Drawing.Point(214, 113);
            this.testGroupBox.Name = "testGroupBox";
            this.testGroupBox.Size = new System.Drawing.Size(320, 93);
            this.testGroupBox.TabIndex = 5;
            this.testGroupBox.TabStop = false;
            this.testGroupBox.Text = "Test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Correct:";
            // 
            // meaningLabel
            // 
            this.meaningLabel.AutoSize = true;
            this.meaningLabel.Location = new System.Drawing.Point(15, 55);
            this.meaningLabel.Name = "meaningLabel";
            this.meaningLabel.Size = new System.Drawing.Size(51, 13);
            this.meaningLabel.TabIndex = 9;
            this.meaningLabel.Text = "Meaning:";
            // 
            // meaningAnswerTextBox
            // 
            this.meaningAnswerTextBox.Location = new System.Drawing.Point(72, 52);
            this.meaningAnswerTextBox.Name = "meaningAnswerTextBox";
            this.meaningAnswerTextBox.Size = new System.Drawing.Size(118, 20);
            this.meaningAnswerTextBox.TabIndex = 8;
            // 
            // correctCountLabel
            // 
            this.correctCountLabel.AutoSize = true;
            this.correctCountLabel.Location = new System.Drawing.Point(265, 30);
            this.correctCountLabel.Name = "correctCountLabel";
            this.correctCountLabel.Size = new System.Drawing.Size(30, 13);
            this.correctCountLabel.TabIndex = 7;
            this.correctCountLabel.Text = "0 / 0";
            this.correctCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kana:";
            // 
            // kanaAnswerTextBox
            // 
            this.kanaAnswerTextBox.Location = new System.Drawing.Point(72, 26);
            this.kanaAnswerTextBox.Name = "kanaAnswerTextBox";
            this.kanaAnswerTextBox.Size = new System.Drawing.Size(118, 20);
            this.kanaAnswerTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kanjiRadioButton);
            this.groupBox2.Controls.Add(this.extendedKanaCheckbox);
            this.groupBox2.Controls.Add(this.testCheckbox);
            this.groupBox2.Controls.Add(this.hiraganaRadioButton);
            this.groupBox2.Controls.Add(this.katakanaRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(214, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 101);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // kanjiRadioButton
            // 
            this.kanjiRadioButton.AutoSize = true;
            this.kanjiRadioButton.Location = new System.Drawing.Point(18, 70);
            this.kanjiRadioButton.Name = "kanjiRadioButton";
            this.kanjiRadioButton.Size = new System.Drawing.Size(48, 17);
            this.kanjiRadioButton.TabIndex = 7;
            this.kanjiRadioButton.Text = "Kanji";
            this.kanjiRadioButton.UseVisualStyleBackColor = true;
            this.kanjiRadioButton.CheckedChanged += new System.EventHandler(this.kanjiRadioButton_CheckedChanged);
            // 
            // extendedKanaCheckbox
            // 
            this.extendedKanaCheckbox.AutoSize = true;
            this.extendedKanaCheckbox.Location = new System.Drawing.Point(173, 48);
            this.extendedKanaCheckbox.Name = "extendedKanaCheckbox";
            this.extendedKanaCheckbox.Size = new System.Drawing.Size(133, 17);
            this.extendedKanaCheckbox.TabIndex = 6;
            this.extendedKanaCheckbox.Text = "Enable extended kana";
            this.extendedKanaCheckbox.UseVisualStyleBackColor = true;
            // 
            // testCheckbox
            // 
            this.testCheckbox.AutoSize = true;
            this.testCheckbox.Location = new System.Drawing.Point(173, 25);
            this.testCheckbox.Name = "testCheckbox";
            this.testCheckbox.Size = new System.Drawing.Size(108, 17);
            this.testCheckbox.TabIndex = 6;
            this.testCheckbox.Text = "Enable test mode";
            this.testCheckbox.UseVisualStyleBackColor = true;
            this.testCheckbox.CheckedChanged += new System.EventHandler(this.testCheckbox_CheckedChanged);
            // 
            // hiraganaRadioButton
            // 
            this.hiraganaRadioButton.AutoSize = true;
            this.hiraganaRadioButton.Location = new System.Drawing.Point(18, 47);
            this.hiraganaRadioButton.Name = "hiraganaRadioButton";
            this.hiraganaRadioButton.Size = new System.Drawing.Size(68, 17);
            this.hiraganaRadioButton.TabIndex = 5;
            this.hiraganaRadioButton.Text = "Hiragana";
            this.hiraganaRadioButton.UseVisualStyleBackColor = true;
            this.hiraganaRadioButton.CheckedChanged += new System.EventHandler(this.hiraganaRadioButton_CheckedChanged);
            // 
            // katakanaRadioButton
            // 
            this.katakanaRadioButton.AutoSize = true;
            this.katakanaRadioButton.Checked = true;
            this.katakanaRadioButton.Location = new System.Drawing.Point(18, 24);
            this.katakanaRadioButton.Name = "katakanaRadioButton";
            this.katakanaRadioButton.Size = new System.Drawing.Size(71, 17);
            this.katakanaRadioButton.TabIndex = 3;
            this.katakanaRadioButton.TabStop = true;
            this.katakanaRadioButton.Text = "Katakana";
            this.katakanaRadioButton.UseVisualStyleBackColor = true;
            this.katakanaRadioButton.CheckedChanged += new System.EventHandler(this.katakanaRadioButton_CheckedChanged);
            // 
            // nextKanaButton
            // 
            this.nextKanaButton.Location = new System.Drawing.Point(214, 212);
            this.nextKanaButton.Name = "nextKanaButton";
            this.nextKanaButton.Size = new System.Drawing.Size(320, 23);
            this.nextKanaButton.TabIndex = 2;
            this.nextKanaButton.Text = "Next";
            this.nextKanaButton.UseVisualStyleBackColor = true;
            this.nextKanaButton.Click += new System.EventHandler(this.nextKanaButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wordLabel);
            this.groupBox1.Controls.Add(this.phoneticLabel);
            this.groupBox1.Controls.Add(this.kanaLabel);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Location = new System.Drawing.Point(97, 182);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(33, 13);
            this.wordLabel.TabIndex = 7;
            this.wordLabel.Text = "water";
            // 
            // phoneticLabel
            // 
            this.phoneticLabel.AutoSize = true;
            this.phoneticLabel.Location = new System.Drawing.Point(6, 182);
            this.phoneticLabel.Name = "phoneticLabel";
            this.phoneticLabel.Size = new System.Drawing.Size(19, 13);
            this.phoneticLabel.TabIndex = 6;
            this.phoneticLabel.Text = "ka";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(541, 244);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Words";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 270);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Japanese Learning";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.testGroupBox.ResumeLayout(false);
            this.testGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label kanaLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button nextKanaButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox testGroupBox;
        private System.Windows.Forms.Label correctCountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kanaAnswerTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox testCheckbox;
        private System.Windows.Forms.RadioButton hiraganaRadioButton;
        private System.Windows.Forms.RadioButton katakanaRadioButton;
        private System.Windows.Forms.CheckBox extendedKanaCheckbox;
        private System.Windows.Forms.Label phoneticLabel;
        private System.Windows.Forms.RadioButton kanjiRadioButton;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label meaningLabel;
        private System.Windows.Forms.TextBox meaningAnswerTextBox;
        private System.Windows.Forms.Label label3;
    }
}

