// https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem

namespace InterviewPreparationKit.Arrays
{
    class RotLeft
    {

        /*
         * Complete the 'rotLeft' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER d
         */

        public static List<int> rotLeft(List<int> a, int d)
        {
            for (int i = 0; i < d; i++)
            {
                a.Add(a[0]);
                a.RemoveAt(0);
            }

            return a;
        }

    }
}
