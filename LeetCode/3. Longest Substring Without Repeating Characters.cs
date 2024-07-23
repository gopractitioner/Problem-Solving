public class Solution
{
    // Solution 1
    public int LengthOfLongestSubstring(string s)
    {
        int[] freq = new int[256]; // 初始化频率数组，大小为256
        Array.Fill(freq, -1); // 将所有值初始化为-1

        int l = 0, r = 0, maxlen = 0; // 左指针，右指针，最大长度

        while (r < s.Length)
        {
            if (freq[s[r]] != -1)
            { // 当前字符在频率数组中已存在
                if (freq[s[r]] >= l)
                { // 且在当前滑动窗口内
                    l = freq[s[r]] + 1; // 移动左指针，跳过重复字符
                }
            }
            freq[s[r]] = r; // 更新当前字符的最新位置
            maxlen = Math.Max(maxlen, r - l + 1); // 更新最大长度
            r++; // 移动右指针
        }

        return maxlen;
    }
    // solution 2:
    //public int LengthOfLongestSubstring(string s) {
    //     if(s.Length==0) return 0;
    //     Dictionary<char, int> d = new Dictionary<char, int>();
    //     int ans=1;
    //     int l=0;
    //     int cnt=0;
    //     for (int i=0;i<s.Length;i++) {
    //         if(d.ContainsKey(s[i])) {
    //             ans=Math.Max(ans, Math.Min(i-l+1,i-d[s[i]]));
    //             l=Math.Max(l,d[s[i]]+1);
    //             d[s[i]]=i;
    //             ans=Math.Max(ans,cnt);
    //             cnt=i-l+1;
    //         } else {
    //             d[s[i]]=i;
    //             cnt++;
    //         }
    //     }
    //     return Math.Max(ans,cnt);
    // }
}