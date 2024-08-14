#include <bits/stdc++.h>
using namespace std;
int a[105];
bool cmp(const &A, const &B)
{
    return A > B;
}
int main()
{
    int t;
    scanf("%d", &t);
    while (t--)
    {
        int n, f, k, v;
        scanf("%d%d%d", &n, &f, &k);
        for (int i = 1; i <= n; i++)
            scanf("%d", &a[i]);
        v = a[f];
        sort(a + 1, a + 1 + n, cmp);
        if (v > a[k])
            printf("YES\n");
        else if (v < a[k])
            printf("NO\n");
        else
        {
            int flag = 0;
            for (int i = k + 1; i <= n; i++)
            {
                if (v == a[i])
                {
                    flag = 1;
                    break;
                }
            }
            if (flag)
                printf("MAYBE\n");
            else
                printf("YES\n");
        }
    }
    return 0;
}