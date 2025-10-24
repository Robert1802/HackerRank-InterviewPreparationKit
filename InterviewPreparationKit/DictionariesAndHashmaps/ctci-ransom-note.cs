// https://www.hackerrank.com/challenges/ctci-ransom-note/problem

namespace InterviewPreparationKit.DictionariesAndHashmaps
{
    class CheckMagazine
    {

        /*
         * Complete the 'checkMagazine' function below.
         *
         * The function accepts following parameters:
         *  1. STRING_ARRAY magazine
         *  2. STRING_ARRAY note
         */

        public static void checkMagazine(List<string> magazine, List<string> note)
        {
            Dictionary<string, int> magazineDict = new();

            foreach (string word in magazine)
            {
                if (magazineDict.ContainsKey(word))
                    magazineDict[word]++;
                else
                    magazineDict.Add(word, 1);
            }

            foreach (string word in note)
            {
                if (magazineDict.ContainsKey(word) && magazineDict[word] > 0)
                {
                    magazineDict[word]--;
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }

    }
}
