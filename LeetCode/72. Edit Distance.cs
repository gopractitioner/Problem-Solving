public class Solution
{
    public int MinDistance(string word1, string word2)
    {
        int[,] dp = new int[505, 505];
        word1 = "#" + word1;
        word2 = "*" + word2;
        for (int i = 0; i < word1.Length; i++) dp[i, 0] = i;
        for (int j = 0; j < word2.Length; j++) dp[0, j] = j;
        dp[0, 0] = 0;
        for (int i = 1; i < word1.Length; i++) for (int j = 1; j < word2.Length; j++)
            {
                if (word1[i] == word2[j]) dp[i, j] = dp[i - 1, j - 1];
                else
                {
                    dp[i, j] = Math.Min(dp[i - 1, j - 1] + 1, Math.Min(dp[i - 1, j] + 1, dp[i, j - 1] + 1));
                }
            }
        return dp[word1.Length - 1, word2.Length - 1];
    }
}