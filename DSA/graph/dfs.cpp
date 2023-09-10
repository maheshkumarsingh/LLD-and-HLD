#include <bits/stdc++.h>
using namespace std;

void dfs(unordered_map<int, vector<int>> &graph, unordered_map<int, bool> &visited, int u)
{
    visited[u] = true;
    cout << u << " " << endl;

    for (int i = 0; i < graph[u].size(); i++)
    {
        int v = graph[u][i];
        if (!visited[v])
        {
            dfs(graph, visited, v);
        }
    }
}
int main()
{
    system("cls");

    unordered_map<int, vector<int>> graph;
    unordered_map<int, bool> visited;

    int nodes, edges;
    cin>>nodes>>edges;

    dfs(graph, visited,1);
    return 0;
}