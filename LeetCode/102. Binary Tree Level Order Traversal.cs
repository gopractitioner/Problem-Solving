/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution
{
    public IList<IList<int>> ans = new List<IList<int>>();
    public void dfs(TreeNode x, int level)
    {
        if (x == null) return;
        if (ans.Count == level) ans.Add(new List<int> { x.val });
        else ans[level].Add(x.val);
        dfs(x.left, level + 1); dfs(x.right, level + 1);
    }
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        dfs(root, 0);
        return ans;
    }
}