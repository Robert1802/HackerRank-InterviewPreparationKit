// https://www.hackerrank.com/challenges/minimum-swaps-2/problem

namespace InterviewPreparationKit.Arrays
{
    class MinimumSwaps
    {

        // Complete the minimumSwaps function below.
        static int minimumSwaps(int[] arr)
        {
            int swaps = 0;
            int i = 0;
            while (i < arr.Length)
            {
                if (arr[i] == i + 1)
                {
                    i++;
                    continue;
                }

                int correctIndex = arr[i] - 1;
                int tmp = arr[correctIndex];
                arr[correctIndex] = arr[i];
                arr[i] = tmp;
                swaps++;
            }
            return swaps;
        }
    }
