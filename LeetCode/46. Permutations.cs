public class Solution
{
    public IList<IList<int>> l = new List<IList<int>>();
    public int[] vis = new int[25];
    public void dfs(int[] nums, int[] vis, List<int> d, int cnt)
    {
        if (cnt == nums.Length)
        {
            l.Add(new List<int>(d));
            return;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (vis[nums[i]] == 0)
            {
                vis[nums[i]] = 1; d.Add(nums[i] - 10);
                dfs(nums, vis, d, cnt + 1);
                vis[nums[i]] = 0;
                d.RemoveAt(d.Count - 1);
            }
        }
    }
    public IList<IList<int>> Permute(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++) nums[i] += 10;
        dfs(nums, vis, new List<int>(), 0);
        return l;
    }
}