// https://gw-c.nowcoder.com/api/sparta/jump/link?link=https%3A%2F%2Fcodeforces.com%2Fblog%2Fentry%2F69108
#include <bits/stdc++.h>
using namespace std;
typedef long long ll;
const int maxn = 104;
struct node
{
    ll a, b;
};
vector<node> c, neg;
bool cmp(const node &A, const node &B)
{
    return (A.a + A.b) > (B.a + B.b);
}
bool cmp2(const node &A, const node &B)
{
    return A.a < B.a;
}
int main()
{
    int n;
    ll r, x, y;
    scanf("%d%I64d", &n, &r);
    for (int i = 1; i <= n; i++)
    {
        scanf("%I64d%I64d", &x, &y);
        if (y >= 0)
            c.push_back({x, y});
        else
            neg.push_back({max(x, -y), y});
    }
    sort(c.begin(), c.end(), cmp2);
    sort(neg.begin(), neg.end(), cmp);
    for (int i = 0; i < c.size(); i++)
        if (r < c[i].a)
        {
            printf("NO");
            return 0;
        }
        else
            r += c[i].b;
    for (int i = 0; i < neg.size(); i++)
        if (r < neg[i].a)
        {
            printf("NO");
            return 0;
        }
        else
            r += neg[i].b;
    printf("YES");
    return 0;
}
