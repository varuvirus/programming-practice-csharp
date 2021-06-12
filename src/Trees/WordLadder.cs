using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingPractice.Trees
{
    public class WordLadder
    {
        public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {

            if (wordList == null || wordList.Count == 0) return 0;

            int steps = 0;

            if (beginWord == endWord)
                return steps;

            HashSet<string> words = new HashSet<string>(wordList);
            HashSet<string> visited = new HashSet<string>();
            Queue<string> queue = new Queue<String>();

            visited.Add(beginWord);
            queue.Enqueue(beginWord);
            steps++;

            while (queue.Count > 0)
            {
                steps++;
                int queueLength = queue.Count;
                for (int i = 0; i < queueLength; i++)
                {
                    string current = queue.Dequeue();

                    if (current == endWord)
                    {
                        return steps;
                    }
                    else
                    {
                        var transformations = GenerateTransformations(current, visited, words);
                        foreach (var transformation in transformations)
                        {
                            if (transformation == endWord)
                                return steps;
                            else
                            {
                                visited.Add(transformation);
                                queue.Enqueue(transformation);
                            }
                        }

                    }
                }

            }

            return 0;
        }

        private static List<string>  GenerateTransformations(string word, HashSet<string> visited, HashSet<string> wordList)
        {
            List<string> rval = new List<string>();

            for (int i = 0; i < word.Length; i++)
            {
                for (char c = 'a'; c < 'z'; c++)
                {
                    var sb = new StringBuilder(word);
                    sb[i] = c;

                    if (!visited.Contains(sb.ToString()) && wordList.Contains(sb.ToString()))
                    {
                        rval.Add(sb.ToString());
                    }
                }
            }

            return rval; 
        }
    }
}
