//https://www.hackerrank.com/challenges/repeated-string/problem

namespace InterviewPreparationKit.Warm_UpChallenges
{
    class RepeatedString
    {

        /*
         * Complete the 'repeatedString' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. LONG_INTEGER n
         */

        public static long repeatedString(string s, long n)
        {
            long stringLength = s.Length;
            long charactersLeft = n % stringLength;
            long repeatingTimes = n / stringLength;
            long numberOfAs = 0;

            char[] charArray = s.ToCharArray();
            foreach (int a in charArray)
                if (a == 'a')
                    numberOfAs += 1;

            numberOfAs *= repeatingTimes;

            for (int i = 0; i < charactersLeft; i++)
                if (s[i] == 'a')
                    numberOfAs += 1;

            return numberOfAs;
        }

    }
}
