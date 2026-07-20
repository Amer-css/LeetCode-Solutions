public class Solution {
    public IList<string> CommonChars(string[] words) {
       Dictionary<char, int> minCounts = new Dictionary<char, int>();

        foreach (char c in words[0]) {
            if (!minCounts.ContainsKey(c)) minCounts[c] = 0;
            minCounts[c]++;
        }

        for (int i = 1; i < words.Length; i++) {
            Dictionary<char, int> currentCounts = new Dictionary<char, int>();
            foreach (char c in words[i]) {
                if (!currentCounts.ContainsKey(c)) currentCounts[c] = 0;
                currentCounts[c]++;
            }

            List<char> keys = new List<char>(minCounts.Keys);
            foreach (char key in keys) {
                if (currentCounts.ContainsKey(key)) {
                    minCounts[key] = Math.Min(minCounts[key], currentCounts[key]);
                } else {
                    minCounts[key] = 0;
                }
            }
        }

        List<string> result = new List<string>();
        foreach (var kvp in minCounts) {
            for (int i = 0; i < kvp.Value; i++) {
                result.Add(kvp.Key.ToString());
            }
        }

        return result; 
    }
}