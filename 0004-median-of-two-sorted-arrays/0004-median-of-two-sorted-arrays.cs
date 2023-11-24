public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        List<int> nums = new List<int>();
        nums.AddRange(nums1);
        nums.AddRange(nums2);
        nums.Sort();
        if (nums.Count % 2 == 0)
        {
            return (new int[] { nums[nums.Count / 2] , nums[(nums.Count / 2) - 1] }).Average();
        }
        else
        {
            return nums[nums.Count / 2];
        }
    }
}