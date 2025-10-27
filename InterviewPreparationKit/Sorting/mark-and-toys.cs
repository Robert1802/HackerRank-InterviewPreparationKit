// https://www.hackerrank.com/challenges/mark-and-toys/problem

namespace InterviewPreparationKit.Sorting
{
    class MaximumToys
    {

        /*
         * Complete the 'maximumToys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY prices
         *  2. INTEGER k
         */

        public static int maximumToys(List<int> prices, int k)
        {
            int toys = 0;

            prices.Sort();

            foreach (int t in prices)
            {
                if (t <= k)
                {
                    k -= t;
                    ++toys;
                }
            }

            return toys;
        }

    }
}
