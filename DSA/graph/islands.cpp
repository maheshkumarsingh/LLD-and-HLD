#include<bits/stdc++.h>
using namespace std;
vector<int> dx = {1,1,1,-1,-1,-1,0,0};
vector<int> dy = {1,-1,0,-1,1,0,1,-1};
bool checkValidity(vector<vector<int>> &visited, int row, int col, int n, int m)
{
    if(row<0 || row>= n || col < 0 || col>= m || visited[row][col] != 1)
        return false;
    return true;
}
void dfs(vector<vector<int>> &visited, int row, int col, int n, int m)
{
    visited[row][col] = -1;
    for(int i=0;i<8;i++)
    {
        int r = row + dx[i];
        int c = col + dy[i];
        if(checkValidity(visited,r,c,n,m))
        {
            dfs(visited, r,c,n,m);
        }
    }
}
int solve(vector<vector<int> > &A) {
    int n = A.size(), m = A[0].size(), islands=0;

    vector<vector<int>> visited(n, vector<int>(m, 0));

    for(int i=0;i<n;i++)
    {
        for(int j=0;j<m;j++)
            visited[i][j] = A[i][j];
    }

    for(int i=0;i<n;i++)
    {
        for(int j=0;j<m;j++)
        {
            if(checkValidity(visited, i,j, n,m))
            {
                dfs(visited, i, j, n ,m);
                islands++;
            }
        }
    }
    return islands;
}

int main(int argc, const char** argv) {
    vector<vector<int>> vec;
    solve(vec);
    return 0;
}


