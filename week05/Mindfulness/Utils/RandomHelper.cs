using System;
using System.Collections.Generic;

namespace MindfulnessProgram.Utils
{
    public static class RandomHelper
    {
        private static Random _random = new Random();

        public static string GetUniqueRandomItem(List<string> source, List<string> used)
        {
            // Refill used list if all have been used
            if (used.Count == source.Count)
                used.Clear();

            // Filter out already used items
            var remaining = source.FindAll(item => !used.Contains(item));

            // Pick a random one from remaining
            int index = _random.Next(remaining.Count);
            string chosen = remaining[index];

            used.Add(chosen);
            return chosen;
        }
    }
}
