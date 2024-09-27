using System.Diagnostics.CodeAnalysis;
using System.Drawing.Imaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Text_Analysis_Application;

namespace Text_Analysis_Application
{



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string theText = "";

            for (int i = 0; i < richTextBox1.Lines.Length; i++)
            {
                theText += richTextBox1.Lines[i];
                theText += " ";
            }

            Regex rgx = new Regex("\\s+");
            theText = rgx.Replace(theText, " ");
            theText = theText.ToLower();

            string[] words = theText.Split(' ');
            List<string> wordList = words.ToList();

            for (int i = 0; i < wordList.Count; i++)
            {
                wordList[i] = extractPuctations(wordList[i]);
            }

            Regex space = new Regex("^\\s+$");

            for (int i = 0; i < wordList.Count; i++)
            {
                if (space.IsMatch(wordList[i]) || wordList[i].Equals(""))
                {
                    wordList.RemoveAt(i);
                }
            }



            MyComparer comparer = new MyComparer();
            Dictionary<DataStructure, int> wordFreq = new Dictionary<DataStructure, int>(comparer);

            for (int i = 0; i < wordList.Count; i++)
            {

                DataStructure temp = new DataStructure(wordList[i]);



                if (!wordFreq.ContainsKey(temp))
                {
                    int freq = 1;

                    if (i == wordList.Count - 1)
                    {
                        wordFreq.Add(temp, freq);
                    }
                    else
                    {
                        for (int j = i + 1; j < wordList.Count; j++)
                        {
                            if (wordList[i].Equals(wordList[j]))
                            {
                                freq++;
                            }
                        }

                        wordFreq.Add(temp, freq);
                    }
                }
            }

            var ordered = wordFreq.OrderByDescending(pair => pair.Value);

            int maxLength = -1;

            foreach (var pair in ordered)
            {
                if (pair.Key.getWord().Length > maxLength)
                {
                    maxLength = pair.Key.getWord().Length;
                }
            }

            if (maxLength > 15)
            {
                maxLength = 15;
            }

            foreach (KeyValuePair<DataStructure, int> pair in ordered)
            {
                if (pair.Key.howManySplits() == 1)
                {
                    string str = pair.Key.getWord() + repeat('.', 3 + maxLength - pair.Key.getWord().Length);
                    listBox1.Items.Add(str + pair.Value.ToString());
                }
                else
                {
                    for (int i = 0; i < pair.Key.howManySplits() - 1; i++)
                    {
                        listBox1.Items.Add(pair.Key.getSplit(i + 1) + "-");
                    }

                    string s = pair.Key.getSplit(pair.Key.howManySplits());
                    s = s + repeat('.', maxLength - s.Length + 3);
                    listBox1.Items.Add(s + pair.Value);
                }

            }
        }

        private string extractPuctations(string word)
        {
            if (word is null)
            {
                throw new ArgumentNullException("The word is null");
            }
            if (word.Length == 0)
            {
                return "";
            }

            int length = word.Length;
            int i = length - 1;
            while (i >= 0 && char.IsPunctuation(word[i]))
            {
                i--;
                length--;
            }

            if (i == -1)
            {
                return "";
            }

            word = word.Substring(0, length);
            i = 0;
            while (i < word.Length && char.IsPunctuation(word[i]))
            {
                i++;
            }
            return word.Substring(i);

        }

        private bool checkWord(string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException("The argument is null");
            }
            if (word.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetterOrDigit(word[i]))
                {
                    return true;
                }
            }

            return false;
        }

        private string repeat(char c, int times)
        {
            if (times < 0)
            {
                throw new ArgumentException("times is negative number");
            }
            if (times == 0)
            {
                return "";
            }

            string padding = "" + c;
            return new StringBuilder(padding.Length * times).Insert(0, padding, times).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            listBox1.Items.Clear();
        }
    }

    class MyComparer : IEqualityComparer<DataStructure>
    {
        public bool Equals(DataStructure? x, DataStructure? y)
        {
            string xx = x.getWord();
            string yy = y.getWord();

            return xx.Equals(yy);
        }

        public int GetHashCode([DisallowNull] DataStructure obj)
        {
            return 0;
        }
    }
}
