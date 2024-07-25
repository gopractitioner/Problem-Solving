public class Solution
{
    public int MinPathSum(int[][] grid)
    {
        int[,] sum = new int[205, 205];
        int n = grid.Length;
        int m = grid[0].Length;
        for (int i = 0; i <= m; i++) sum[0, i] = 8000001;
        for (int i = 0; i <= n; i++) sum[i, 0] = 8000001;
        sum[0, 0] = sum[0, 1] = sum[1, 0] = 0;
        for (int i = 1; i <= n; i++) for (int j = 1; j <= m; j++)
                sum[i, j] = Math.Min(sum[i - 1, j] + grid[i - 1][j - 1], sum[i, j - 1] + grid[i - 1][j - 1]);
        return sum[n, m];
    }
}