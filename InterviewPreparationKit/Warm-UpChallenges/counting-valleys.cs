// https://www.hackerrank.com/challenges/counting-valleys/problem

namespace InterviewPreparationKit.Warm_UpChallenges
{
    class CountingValleys
    {

        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */

        public static int countingValleys(int steps, string path)
        {
            // Solution 1
            char[] charPath = path.ToCharArray();
            int hight = 0;
            int valleys = 0;
            foreach (char step in charPath)
            {
                if (step.Equals('U'))
                {
                    if (hight == -1)
                        ++valleys;
                    ++hight;
                }
                else
                    --hight;
            }
            return valleys;
        }

    }
}
