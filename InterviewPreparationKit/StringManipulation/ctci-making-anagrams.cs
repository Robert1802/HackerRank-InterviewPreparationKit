// https://www.hackerrank.com/challenges/ctci-making-anagrams/problem

namespace InterviewPreparationKit.StringManipulation
{
    class MakeAnagram
    {

        /*
         * Complete the 'makeAnagram' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. STRING a
         *  2. STRING b
         */

        public static int makeAnagram(string a, string b)
        {
            int[] charCounts = new int[26];

            foreach (char c in a)
            {
                charCounts[c - 'a']++;
            }

            foreach (char c in b)
            {
                charCounts[c - 'a']--;
            }

            int totalDeletions = 0;
            foreach (int countDifference in charCounts)
            {
                totalDeletions += Math.Abs(countDifference);
            }

            return totalDeletions;
        }

    }
}
