// https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem

namespace InterviewPreparationKit.StringManipulation
{
    class SherlockAndTheValidString
    {

        /*
         * Complete the 'isValid' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string isValid(string s)
        {
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts.Add(c, 1);
                }
            }

            Dictionary<int, int> freqCounts = new Dictionary<int, int>();
            foreach (int count in charCounts.Values)
            {
                if (freqCounts.ContainsKey(count))
                {
                    freqCounts[count]++;
                }
                else
                {
                    freqCounts.Add(count, 1);
                }
            }

            if (freqCounts.Count == 1)
            {
                return "YES";
            }

            if (freqCounts.Count == 2)
            {
                int[] frequencies = freqCounts.Keys.ToArray();
                int freq1 = frequencies[0];
                int count1 = freqCounts[freq1];
                int freq2 = frequencies[1];
                int count2 = freqCounts[freq2];

                if ((freq1 == 1 && count1 == 1) || (freq2 == 1 && count2 == 1))
                {
                    int singleFreq = (freq1 == 1 && count1 == 1) ? freq1 : freq2;
                    int dominantFreq = (singleFreq == freq1) ? freq2 : freq1;

                    return "YES";
                }

                int higherFreq = Math.Max(freq1, freq2);
                int lowerFreq = Math.Min(freq1, freq2);

                if (
                    (higherFreq == lowerFreq + 1) &&
                    (freqCounts[higherFreq] == 1)
                   )
                {
                    return "YES";
                }
            }

            return "NO";

        }

    }
}
