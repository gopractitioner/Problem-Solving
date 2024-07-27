public class Solution
{
    public bool DoesAliceWin(string s)
    {
        HashSet<char> v = new HashSet<char>();
        v.Add('a'); v.Add('e'); v.Add('i'); v.Add('o'); v.Add('u');
        int cnt = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (v.Contains(s[i])) cnt++;
        }
        if (cnt == 0) return false;
        return true;
    }
}