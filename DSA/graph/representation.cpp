#include <bits/stdc++.h>
using namespace std;

int main()
{
    system("cls");
    cout<<"Hello Visual Studio"<<endl;
    int n, m;
    cin >> n >> m;
    int source;
    cin>>source;
    vector<int> graph[n + 1];

    for (int i = 0; i < m; i++)
    {
        int u, v;
        cin >> u >> v;
        cout << u << v << endl;
        graph[u].push_back(v);
        graph[v].push_back(u);
    }

    queue<int> que;
    vector<bool> visited(n, false);
    
    que.push(source);
    visited[source] = true;

    while(!que.empty())
    {
        int u = que.front();
        que.pop();
        cout<<u<<"-> ";
        for(int i=0;i< graph[u].size();i++)
        {
            int v = graph[u][i];
            if(!visited[v])
            {
                que.push(v);
                visited[v] = true;
                cout<<v<<" ";
            }
        }
        cout<<endl;
    }

    return 0;
}