#include <bits/stdc++.h>
using namespace std;

int main()
{
    system("cls");

    vector<pair<int, int>> vec = {{1, 2}, {2, 3}, {3, 4}, {4, 5}};

    int nodes = 5;
    int edges = vec.size();
    int source =1;
    int destination = 5;
    vector<int> graph[nodes + 1];
    for (auto &it : vec)
    {
        int u = it.first;
        int v = it.second;

        graph[u].push_back(v);  // directed graph
    }

    vector<bool> visited(nodes+1, false);

    queue<int> que;
    que.push(source);
    visited[source] = true;

    while(!que.empty())
    {
        int u = que.front();
        que.pop();

        for(auto &neighbour : graph[u])
        {
            if(!visited[neighbour])
            {
                que.push(neighbour);
                visited[neighbour] = true;
            }
        }
    }
    cout<<"Answer : "<<visited[destination]<<endl;
    return 0;
}