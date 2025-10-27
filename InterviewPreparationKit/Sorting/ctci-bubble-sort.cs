// https://www.hackerrank.com/challenges/ctci-bubble-sort/problem

namespace InterviewPreparationKit.Sorting
{
    class CountSwaps
    {

        /*
         * Complete the 'countSwaps' function below.
         *
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        public static void countSwaps(List<int> a)
        {
            int numSwaps = 0;
            int n = a.Count();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        (a[j + 1], a[j]) = (a[j], a[j + 1]);
                        numSwaps++;
                    }
                }
            }
            Console.WriteLine($"Array is sorted in {numSwaps} swaps.", numSwaps);
            Console.WriteLine("First Element: " + a.First().ToString());
            Console.WriteLine("Last Element: " + a.Last().ToString());
        }

    }
}
