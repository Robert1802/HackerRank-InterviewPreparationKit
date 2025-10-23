// https://www.hackerrank.com/challenges/2d-array/problem

namespace InterviewPreparationKit.Arrays
{
    class HourglassSum
    {
        public static int hourglassSum(List<List<int>> arr)
        {
            int maxSum = int.MinValue;

            for (int i = 0; i < 4; i++) // rows (0–3)
            {
                for (int j = 0; j < 4; j++) // cols (0–3)
                {
                    int sum =
                        arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + // top
                        arr[i + 1][j + 1] +                        // middle
                        arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]; // bottom

                    if (sum > maxSum)
                        maxSum = sum;
                }
            }

            return maxSum;
        }
    }
}
