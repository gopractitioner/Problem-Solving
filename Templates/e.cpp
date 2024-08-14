结构体排序：
#include <bits/stdc++.h>
using namespace std;
typedef long long ll;
const int maxn = 2e5 + 4;
int a[maxn], m, n, k, t, dp[maxn];
struct Node
{
    int l, r, d;
    bool operator<(const Node &T) const
    {
        if (l != T.l)
            return l < T.l;
        return r > T.r;
    }
} pp[maxn];
vector<Node> vec;
bool check(int mid)
{
    vec.clear();
    vec.push_back({0, 0, 0});
    int r = 0;
    for (int i = 1; i <= k; i++)
        if (pp[i].d > a[mid] && pp[i].r > r)
        {
            vec.push_back(pp[i]);
            r = pp[i].r;
        }
    dp[0] = 0;
    for (int i = 1; i < vec.size(); i++)
        if (vec[i - 1].r >= vec[i].l)
            dp[i] = dp[i - 1] + 2 * (vec[i].r - vec[i - 1].r);
        else
            dp[i] = dp[i - 1] + 2 * (vec[i].r - vec[i].l + 1);
    return (n + 1 + dp[vec.size() - 1]) <= t;
}
int main()
{
    scanf("%d%d%d%d", &m, &n, &k, &t);
    for (int i = 1; i <= m; i++)
        scanf("%d", &a[i]);
    sort(a + 1, a + 1 + m);
    for (int i = 1; i <= k; i++)
        scanf("%d%d%d", &pp[i].l, &pp[i].r, &pp[i].d);
    sort(pp + 1, pp + 1 + k);
    int l = 1, r = m, ans = m + 1;
    while (l <= r)
    {
        int mid = (l + r) >> 1;
        if (check(mid))
            ans = mid, r = mid - 1;
        else
            l = mid + 1;
    }
    printf("%d", m - ans + 1);
    return 0;
}
