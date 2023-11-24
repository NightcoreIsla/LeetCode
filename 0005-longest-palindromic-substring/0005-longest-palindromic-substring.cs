public class Solution {
    public string LongestPalindrome(string s) {
        List<string> nums = new List<string>();
        var sr = new string(s.Reverse().ToArray());
        int start = 0;
        int seq = 1;
        while (start + seq <= s.Length)
        {
            if (s.Substring(start, seq) == sr.Substring(s.Length - start - seq, seq))
            {
                nums.Add(s.Substring(start, seq));
                seq++;
            }
            else if (start + seq < s.Length)
            {
                seq++;
            }
            else
            {
                start++;
                seq = 1;
            }
        }
        return nums.FirstOrDefault(x => x.Length == nums.Max(y => y.Length));
    }
}