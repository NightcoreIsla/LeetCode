public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int a = target - nums[i];
            if (dic.ContainsKey(a))
            {
                return new int[] { dic[a], i };
            } 
                dic[nums[i]] = i;
        }
        return new int[] { };
    }
}