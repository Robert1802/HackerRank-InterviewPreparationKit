// https://www.hackerrank.com/challenges/sock-merchant/problem

using System.ComponentModel.DataAnnotations.Schema;

namespace InterviewPreparationKit.Warm_UpChallenges
{
    class Result
    {

        /*
         * Complete the 'sockMerchant' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER_ARRAY ar
         */

        public static int sockMerchant(int n, List<int> ar)
        {
            // Solution 1

            //List<int> distinctSocks = ar.Distinct().ToList();
            //int pairs = 0;

            //foreach (int sock in distinctSocks)
            //{
            //    int sockAmmount = ar.Count(s => s == sock);
            //    if (sockAmmount % 2 == 0)
            //    {
            //        pairs += sockAmmount / 2;
            //    }
            //    else
            //    {
            //        pairs += (sockAmmount - 1) / 2;
            //    }
            //}
            //return pairs;

            // Solution 2

            int pairs = 0;

            Dictionary<int, int> sockAmmount = new();

            foreach (int sock in ar)
            {
                if (sockAmmount.ContainsKey(sock))
                {
                    sockAmmount[sock] += 1;
                }
                else
                {
                    sockAmmount.Add(sock, 1);
                }
            }

            foreach (KeyValuePair<int, int> sock in sockAmmount)
            {
                if (sock.Value % 2 == 0)
                {
                    pairs += sock.Value / 2;
                }
                else
                {
                    pairs += (sock.Value - 1) / 2;
                }
            }

            return pairs;

        }

    }

}

