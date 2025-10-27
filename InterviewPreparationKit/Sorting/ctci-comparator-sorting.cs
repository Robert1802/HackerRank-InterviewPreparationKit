// https://www.hackerrank.com/challenges/ctci-comparator-sorting/problem

namespace InterviewPreparationKit.Sorting
{
    class Comparator
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

            // 1. Read the number of players
            int n = Convert.ToInt32(Console.ReadLine());

            // 2. Create an array to hold the players
            Player[] players = new Player[n];

            // 3. Read each player's data and create Player objects
            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                string name = inputs[0];
                int score = Convert.ToInt32(inputs[1]);
                players[i] = new Player(name, score);
            }

            // 4. Create an instance of our comparator
            Checker myChecker = new Checker();

            // 5. Sort the array using our checker
            Array.Sort(players, myChecker);

            // 6. Print the sorted list
            foreach (Player p in players)
            {
                Console.WriteLine(p.name + " " + p.score);
            }
        }

        // Defines the Player object
        public class Player
        {
            public string name;
            public int score;

            public Player(string name, int score)
            {
                this.name = name;
                this.score = score;
            }
        }

        // Defines the comparison logic
        public class Checker : IComparer<Player>
        {
            public int Compare(Player a, Player b)
            {
                // Compare by score in DESCENDING order
                int scoreCompare = b.score.CompareTo(a.score);

                if (scoreCompare != 0)
                {
                    // If scores are different, return that result
                    return scoreCompare;
                }
                else
                {
                    // If scores are the same, compare by name in ASCENDING order
                    return a.name.CompareTo(b.name);
                }
            }
        }
    }
}
