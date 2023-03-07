using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            var contains = false;
            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            if (ignoreCase == true)
            {
                word = word.ToLower();
                List<string> list = words.Select(x => x.ToLower()).ToList();
                contains = list.Contains(word);
            }
            if (words.Contains(word) && ignoreCase == false)
            {
                contains = true;
            }

            return contains;

        }

        public bool IsPrimeNumber(int num)
        {
            var isPrime = true;

            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int x = 2; x <= num / 2; x++)
                {
                    if (num % x == 0)
                    {
                        isPrime = false;
                    }
                }
            }
            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uniqueIndex;

            for (int i = 0; i < str.Length; i++)
            {
                uniqueIndex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uniqueIndex = false;
                    }
                }
                if (uniqueIndex == true)
                {
                    index = i;
                }
            }

            return index;

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var count = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                int currentcount = 1;

                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] != numbers[i])
                    {
                        break;
                    }

                    currentcount++;
                }
                if (currentcount > count)
                {
                    count = currentcount;
                }
            }

            return count;

        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            double[] turn = new double[0];
            if (elements == null || n < 0)
            {
                return turn;
            }

            return elements.Where((x, i) => x % n == 0).ToArray();
        }
    }
}
    
