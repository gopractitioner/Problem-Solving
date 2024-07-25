public class Solution
{
    public int mod = 1000000007;
    public int NumberOfWays(int startPos, int endPos, int k)
    {
        int[,] dp = new int[3005, 1005];
        startPos += 1000;
        dp[startPos, 0] = 1;
        for (int j = 1; j <= k; j++) for (int i = startPos - k; i <= startPos + k; i++)
                dp[i, j] = (dp[i - 1, j - 1] + dp[i + 1, j - 1]) % mod;
        return dp[endPos + 1000, k];
    }
}