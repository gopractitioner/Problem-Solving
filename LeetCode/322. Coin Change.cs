public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int[] dp = new int[10005];
        for(int i=0;i<=amount;i++) dp[i]=10005;
        dp[0]=0;
        for(int i=0;i<coins.Length;i++) for(int j=coins[i];j<=amount;j++)
            dp[j] = Math.Min(dp[j], dp[j-coins[i]] + 1);
        return dp[amount]==10005?-1:dp[amount];
    }
}