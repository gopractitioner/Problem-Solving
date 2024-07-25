class Solution
{
public:
    int numTrees(int n)
    {
        int f[20];
        f[0] = f[1] = 1, f[2] = 2;
        for (int i = 3; i <= n; i++)
            for (int j = 0; j < i; j++)
                f[i] += f[j] * f[i - 1 - j];
        return f[n];
    }
};