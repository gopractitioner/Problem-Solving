public class Solution
{
    public int MinChanges(int n, int k)
    {
        List<int> a = new List<int>();
        List<int> b = new List<int>();
        while (n > 0)
        {
            a.Add(n % 2);
            n >>= 1;
        }
        while (k > 0)
        {
            b.Add(k % 2);
            k >>= 1;
        }
        int cnt = 0;
        if (a.Count < b.Count) return -1;
        for (int i = 0; i < b.Count; i++)
        {
            if (a[i] == 0 && b[i] == 1) return -1;
            if (a[i] == 1 && b[i] == 0) cnt++;
        }
        if (a.Count == b.Count) return cnt;
        for (int i = b.Count; i < a.Count; i++)
        {
            if (a[i] == 1) cnt++;
        }
        return cnt;
    }
}