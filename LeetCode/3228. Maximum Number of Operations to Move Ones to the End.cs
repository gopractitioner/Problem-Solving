public class Solution
{
    public int MaxOperations(string s)
    {
        int cnt = 0;
        int sum = 0;
        for (int i = s.Length - 2; i >= 0; i--)
        {
            if (s[i] == '1' && s[i + 1] == '0')
            {
                sum += cnt + 1;
                cnt++;
            }
            if (s[i] == '1' && s[i + 1] == '1')
            {
                sum += cnt;
                //cnt++;
            }
        }
        return sum;
    }
}