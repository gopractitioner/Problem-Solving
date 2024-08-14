#include <cstdio>
#include <cstring>
#include <deque>
#include <functional>
#include <list>
#include <map>
#include <iomanip>
#include <iostream>
#include <queue>
#include <set>
#include <stack>
#include <string>
#include <vector>

// 单向链表
struct Node
{
    int value;
    Node *next;
};
// 双向链表
struct Node
{
    int value;
    Node *left;
    Node *right;
};
void insertNode(int i, Node *p)
{
    Node *node = new Node;
    node->value = i;
    node->next = p->next;
    p->next = node;
}

const int maxn = 1005;
int fa[maxn * maxn];  // father
int ran[maxn * maxn]; // rank
int id[maxn][maxn];
int Find(int x) { return fa[x] = (fa[x] == x ? x : Find(fa[x])); }
void Union(int x, int y)
{
    int fx = Find(x), fy = Find(y);
    if (ran[fx] >= ran[fy])
    {
        fa[fy] = fx;
        ran[fx] += ran[fy];
    }
    else
    {
        fa[fx] = fy;
        ran[fy] += ran[fx];
    }
}

int main()
{

    return 0;
}