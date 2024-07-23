public class Solution
{
    public bool ValidPalindrome(string s)
    {
        int l = 0, r = s.Length - 1;
        int flag = 0;
        while (l < r)
        {
            if (s[l] == s[r])
            {
                l++; r--;
            }
            else
            {
                flag = 1;
                break;
            }
        }
        if (flag == 0) return true;
        if (flag == 1)
        {
            int newL = l, newR = r - 1;
            flag = 0;
            while (newL < newR)
            {
                if (s[newL] == s[newR])
                {
                    newL++; newR--;
                }
                else
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0) return true;
            flag = 0;
            newL = l + 1; newR = r;
            while (newL < newR)
            {
                if (s[newL] == s[newR])
                {
                    newL++; newR--;
                }
                else
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0) return true;
        }
        return false;
    }
}