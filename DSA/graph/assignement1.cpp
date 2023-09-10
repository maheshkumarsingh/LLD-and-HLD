#include<bits/stdc++.h>
using namespace std;

int main()
{
   system("cls");
   int A;
   cin>>A;
   vector<vector<int>> B;
   vector<int> graph[A+1];

    for(int i=0;i<B.size();i++)
    {
        int u = B[i][0];
        int v = B[i][1];
        graph[u].push_back(v);
    }

    vector<bool> visited(A, false);
    queue<int> que;
    visited[1] = true;
    que.push(1);

    while(!que.empty())
    {
        int u = que.front();
        que.pop();

        for(int i=0;i<graph[u].size();i++)
        {
            int v = B[u][i];
            if(!visited[v])
            {
                que.push(v);
                visited[v] = true;
            }
        }
    }
    
    return visited[A];
   return 0;
}