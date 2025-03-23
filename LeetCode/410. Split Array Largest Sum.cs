/*
Solution 1: Dynamic Programming
*/
public class Solution
{
    public int SplitArray(int[] nums, int k)
    {
        int n = nums.Length;
        long[] prefixSum = new long[n + 1];
        long[,] dp = new long[n + 1, k + 1];
        for (int i = 0; i < n; i++)
        {
            prefixSum[i + 1] = prefixSum[i] + nums[i];
        }
        for (int i = 0; i <= n; i++) for (int j = 0; j <= k; j++) dp[i, j] = Int32.MaxValue;
        dp[0, 0] = 0;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= k; j++)
            {
                for (int m = 1; m <= i; m++)
                {
                    dp[i, j] = Math.Min(dp[i, j], Math.Max(dp[m - 1, j - 1], prefixSum[i] - prefixSum[m - 1]));
                }
            }
        }
        return (int)dp[n, k];
    }
}


/*
Solution 2: BinarySearch + Greedy
*/

// public class Solution {
//     /*
//         Returns: int index
//         Search for the smallest index in a sub-array (from leftIndex to the rightIndex )  of an non-decreasing array that ensures array[index] >= value
//     */
//     public int Upper_Bound(int value, int[] array, int leftIndex, int rightIndex) 
//     {
//         int l = leftIndex, r = rightIndex, mid;
//         while (l <= r)
//         {
//             mid = l + (r - l) / 2;
//             if (array[mid] <= value) {
//                 l = mid + 1;
//             } else {
//                 r = mid - 1;
//             }
//         }        
//         return l == 0 ? -1 : l - 1;
//     }
//     public bool Check(int sum, int k, int[] prefixSum)
//     {
//         int currentIndex = -1, currentSum = sum;
//         while (currentIndex < prefixSum.Length - 1 && k > 0)
//         {
//             if(currentIndex != -1) currentSum = sum + prefixSum[currentIndex];
//             currentIndex = Upper_Bound(currentSum, prefixSum, currentIndex + 1, prefixSum.Length - 1);
//             if (currentIndex < 0 || currentIndex >= prefixSum.Length) return false;
//             k--;
//         }
//         return currentIndex < prefixSum.Length - 1 ? false: true;        
//     }
//     public int SplitArray(int[] nums, int k) {
//         int maxSum, n = nums.Length;
//         int[] prefixSum = new int[n];
//         prefixSum[0] = nums[0];
//         for (int i = 1; i < n; i++) 
//         {
//             prefixSum[i] = prefixSum[i - 1] + nums[i];  
//         }
//         int l = 0, r = prefixSum[n - 1];
//         int mid = l + (r - l) / 2;
//         while (l <= r) 
//         {
//             mid = l + (r - l) / 2;
//             if (Check(mid, k, prefixSum)) {
//                 r = mid - 1;
//             } else {
//                 l = mid + 1;
//             }
//         }
//         maxSum = l;
//         return maxSum;
//     }    
// }

// /*
// n = nums.Length
// maxSum <= 10^9
// estimated maximum check times: log2(10^9) about 30 

// sum

// k times * log2(n)

// 30 * 1000 * 10 = 3 * 10^5

// */