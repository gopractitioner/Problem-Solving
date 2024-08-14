#include <bits/stdc++.h>
using namespace std;

int main()
{
    int t;
    scanf("%d", &t);
    while (t--)
    {
        int n, k;
        scanf("%d%d", &n, &k);
        if (k >= n - 1)
            printf("1\n");
        else
            printf("%d\n", n);
    }
    return 0;
}