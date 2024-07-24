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
    public List<int> l = new List<int>();
    public void subTree(TreeNode c)
    {
        if (c.left != null) subTree(c.left);
        l.Add(c.val);
        if (c.right != null) subTree(c.right);
    }
    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root == null) return new int[] { };
        subTree(root);
        return l;
    }
}