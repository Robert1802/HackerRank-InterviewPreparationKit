// https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem

namespace InterviewPreparationKit.Warm_UpChallenges
{
    class JumpingOnClouds
    {

        /*
         * Complete the 'jumpingOnClouds' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY c as parameter.
         */

        public static int jumpingOnClouds(List<int> c)
        {
            int jumps = 0;
            int i = 0;

            while (i < c.Count - 1)
            {
                if (i + 2 < c.Count && c[i + 2] == 0)
                    i += 2;
                else
                    i += 1;

                jumps++;
            }

            return jumps;
        }

    }
}
