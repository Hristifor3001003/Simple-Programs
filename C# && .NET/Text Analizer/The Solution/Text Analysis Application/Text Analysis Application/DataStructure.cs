using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Text_Analysis_Application
{

    /** This class is used for spliting the words that have more than 10 letters.
     * 
     *  @author Hristifor Sotirovski
     */
    class DataStructure
    {
        private string[] lines;
        private string word;
        

        public DataStructure(string word)
        {
            if (word == null) throw new ArgumentNullException("word", "The argument is null.");
            if (word.Length == 0)
            {
                throw new ArgumentException("word", "The argument is empty");
            }

            Regex rgx = new Regex("\\s+");

            if(rgx.IsMatch(word)) {
                throw new Exception("The word contains only spaces.");
            }

            this.word = word;

            int numberOfWords = 0;

            if(word.Length <= 15) {
                numberOfWords = 1;
            }
            else
            {
                numberOfWords = word.Length / 15;
                if(word.Length % 15 != 0)
                {
                    numberOfWords++;
                }
            }

            lines = new string[numberOfWords];
            int startIndex = 0;

            for(int i = 0; i  < numberOfWords - 1; i++)
            {
                lines[i] = word.Substring(startIndex, 15);
                startIndex += 15;
            }

            lines[numberOfWords - 1] = word.Substring(startIndex);
        }

        public int howManySplits()
        {
            return lines.Length;
        }

        public string getSplit(int index)
        {
            if(index < 1 || index > lines.Length)
            {
                throw new ArgumentException("index", "The index is out of range");
            }
            return lines[index - 1];
        }

        public string getWord()
        {
            return word;
        }

        public bool Equals(DataStructure ds)
        {
            return word.Equals(ds.word);
        }
    }
}
