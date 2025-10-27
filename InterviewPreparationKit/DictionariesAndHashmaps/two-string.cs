// https://www.hackerrank.com/challenges/two-strings/problem

namespace InterviewPreparationKit.DictionariesAndHashmaps
{
    class TwoStrings
    {

        /*
         * Complete the 'twoStrings' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. STRING s1
         *  2. STRING s2
         */

        public static string twoStrings(string s1, string s2)
        {
            // Solution 1

            //string matchingString = "NO";

            //HashSet<char> hash1 = new();

            //char[] char1 = s1.ToCharArray();

            //foreach (char c in char1)
            //    hash1.Add(c);


            //char[] char2 = s2.ToCharArray();

            //foreach (char c in char2)
            //{
            //    if (hash1.Contains(c))
            //    {
            //        matchingString = "YES";
            //        break;
            //    }
            //}
            //return matchingString;

            // Solution 2

            HashSet<char> set1 = new HashSet<char>(s1);

            if (s2.Any(set1.Contains))
            {
                return "YES";
            }

            return "NO";
        }

    }
}
