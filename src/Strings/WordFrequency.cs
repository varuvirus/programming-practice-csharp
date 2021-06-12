using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingPractice.Strings
{
    public class WordFrequency
    {
        public static string MostCommonWord(string paragraph, string[] banned)
        {

            if (string.IsNullOrEmpty(paragraph))
            {
                return string.Empty;
            }

            var bannedWords = new HashSet<string>(banned);
            string newParagraph = paragraph.ToLower().Replace("!", " ").Replace("?", " ").Replace("\'", " ").Replace(",", " ").Replace(";", " ").Replace(".", " ");

            if (string.IsNullOrEmpty(newParagraph))
            {
                return string.Empty;
            }



            var words = newParagraph.Split(' ');

            if (words == null || words.Length == 0)
            {
                return string.Empty;
            }

            var wordFrequency = new Dictionary<string, int>();
            var maxCount = 0;
            string maxCountWord = string.Empty;

            foreach (var word in words)
            {
                if (!string.IsNullOrEmpty(word) && !bannedWords.Contains(word))
                {
                    if (wordFrequency.ContainsKey(word))
                    {
                        wordFrequency[word]++;
                    }
                    else
                    {
                        wordFrequency.Add(word, 1);
                    }

                    if (wordFrequency[word] > maxCount)
                    {
                        maxCount = wordFrequency[word];
                        maxCountWord = word;
                    }
                }
            }

            return maxCountWord;


        }
    }
}
