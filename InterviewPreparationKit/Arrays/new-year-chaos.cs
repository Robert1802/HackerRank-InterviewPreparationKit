// https://www.hackerrank.com/challenges/new-year-chaos/problem

namespace InterviewPreparationKit.Arrays
{
    class MinimumBribes
    {

        /*
         * Complete the 'minimumBribes' function below.
         *
         * The function accepts INTEGER_ARRAY q as parameter.
         */

        public static void minimumBribes(List<int> q)
        {
            int bribes = 0;

            for (int i = 0; i < q.Count; i++)
            {
                if (q[i] - (i + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }

                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                {
                    if (q[j] > q[i])
                        bribes++;
                }
            }

            Console.WriteLine(bribes);
        }

    }
}
