public class Solution
{
    public bool CanJump(int[] nums)
    {
        if (nums.Length == 1) return true;
        int[] f = new int[10005];
        f[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (f[i - 1] < 1) f[i] = 0;
            else f[i] = Math.Max(nums[i], f[i - 1] - 1);
        }
        return f[nums.Length - 2] > 0 ? true : false;
    }
}