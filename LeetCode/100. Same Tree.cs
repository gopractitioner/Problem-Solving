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
    // public List<Tuple<int, int, int>> pnodes = new List<Tuple<int, int, int>>();
    // public List<Tuple<int, int, int>> qnodes = new List<Tuple<int, int, int>>();
    // public void fp(TreeNode c, int level, int side) {
    //     if (c.left!=null) fp(c.left, level+1, 1);
    //     pnodes.Add(Tuple.Create(level, side, c.val));
    //     if (c.right!=null) fp(c.right, level+1, 2);
    // }
    // public void fq(TreeNode c, int level, int side) {
    //     if (c.left!=null) fq(c.left, level+1, 1);
    //     qnodes.Add(Tuple.Create(level, side, c.val));
    //     if (c.right!=null) fq(c.right, level+1, 2);
    // }
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        // if(p==null){
        //     return q==null?true:false;
        // } 
        // if(q==null) return false;
        // fp(p, 0, 0); fq(q, 0, 0);
        // return pnodes.SequenceEqual(qnodes)?true:false;
        if (p == null && q == null) return true;
        else if (p == null || q == null) return false;
        else if (p.val != q.val) return false;
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}