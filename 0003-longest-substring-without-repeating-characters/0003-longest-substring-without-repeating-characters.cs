public class Solution {
    public int LengthOfLongestSubstring(string s) {
        List<string> subs = new List<string>()
        {
            string.Empty
        };
        foreach (char c in s)
        {
            var lastSub = subs.Last();
            if (lastSub.Contains(c.ToString()))
            {
                subs.Add(lastSub.Substring(lastSub.IndexOf(c) + 1) +c.ToString());
            }
            else
            {
                subs[subs.Count - 1] = lastSub + c.ToString();
            }
        }
        return subs.Max(x => x.Count());
    }
}