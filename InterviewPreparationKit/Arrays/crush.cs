// https://www.hackerrank.com/challenges/crush/problem

namespace InterviewPreparationKit.Arrays
{
    class ArrayManipulation
    {

        /*
         * Complete the 'arrayManipulation' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. 2D_INTEGER_ARRAY queries
         */

        public static long arrayManipulation(int n, List<List<int>> queries)
        {
            long[] arr = new long[n + 2];

            foreach (var query in queries)
            {
                int a = query[0];
                int b = query[1];
                int k = query[2];

                arr[a] += k;
                arr[b + 1] -= k;
            }

            long max = 0;
            long current = 0;

            for (int i = 1; i <= n; i++)
            {
                current += arr[i];
                if (current > max)
                {
                    max = current;
                }
            }

            return max;
        }

    }
}
