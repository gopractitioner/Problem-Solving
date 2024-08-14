#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;
int a[10];
int main()
{
    int t, ans;
    int n, m;
    char s[55];
    scanf("%d", &t);
    while (t--)
    {
        scanf("%d%d", &n, &m);
        scanf("%s", s);
        ans = 0;
        for (int i = 0; i < 7; i++)
            a[i] = 0;
        for (int i = 0; i < n; i++)
        {
            a[s[i] - 'A']++;
        }
        for (int i = 0; i < 7; i++)
            if (a[i] < m)
                ans = ans + m - a[i];
        printf("%d\n", ans);
    }
    return 0;
}