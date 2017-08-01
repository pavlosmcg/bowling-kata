using System;

namespace Bowling
{
    public class Scorer
    {
        public int Calculate(string[] turns) {
            int total = 0;

            for (int i = 0; i < turns.Length; i++)
            {
                int turnScore;
                if (int.TryParse(turns[i], out turnScore))
                    total += turnScore;
            }

            return total;
        }
    }
}
