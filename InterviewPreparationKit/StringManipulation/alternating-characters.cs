// https://www.hackerrank.com/challenges/alternating-characters/problem

namespace InterviewPreparationKit.StringManipulation
{
    class AlternatingCharacters
    {

        /*
         * Complete the 'alternatingCharacters' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts STRING s as parameter.
         */

        public static int alternatingCharacters(string s)
        {

            if (s.Length < 2)
            {
                return 0;
            }

            int deletions = 0;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    deletions++;
                }
            }

            return deletions;
        }

    }
}
