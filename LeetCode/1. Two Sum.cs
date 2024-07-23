public class newNum
{
    public int Value { get; set; }
    public int Index { get; set; }
    public newNum(int value, int index)
    {
        Value = value;
        Index = index;
    }
}
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int n = nums.Length;
        newNum[] newNums = new newNum[n];
        for (int i = 0; i < n; i++)
        {
            newNums[i] = new newNum(nums[i], i);
            //newNums[i].Value = nums[i];
            //newNums[i].Index = i;
        }
        Array.Sort(newNums, (x, y) => x.Value.CompareTo(y.Value));
        int l = 0, r = n - 1;
        while (l < r)
        {
            if (newNums[l].Value + newNums[r].Value == target)
            {
                return new int[] { newNums[l].Index, newNums[r].Index };
            }
            else if (newNums[l].Value + newNums[r].Value < target)
            {
                l++;
            }
            else
            {
                r--;
            }
        }
        return new int[] { newNums[l].Index, newNums[r].Index };
    }
}