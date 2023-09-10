#include<bits/stdc++.h>
using namespace std;

bool check(int x, int y, int n, int m, vector<vector<int>> &A, vector<vector<bool>> &vis)
{
    if (x >= 0 && y >= 0 && x < n && y < m && (A[x][y] != 0) && vis[x][y] == false)
        return true;
    return false;
}
int solve(vector<vector<int>> &A)
{
    int dx[] = {-1, 0, 1, 0};
    int dy[] = {0, -1, 0, 1};

    int n = A.size();
    int m = A[0].size();

    queue<pair<int, int>> que;
    vector<vector<bool>> vis(n, vector<bool>(m, false));
    vector<vector<int>> time(n, vector<int>(m, -1));

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (A[i][j] == 2)
            {
                que.push(make_pair(i, j));
                vis[i][j] = true;
                time[i][j] = 0;
            }
        }
    }

    while (!que.empty())
    {
        pair<int, int> tp = que.front();
        que.pop();
        int x = tp.first;
        int y = tp.second;
        for (int k = 0; k < 4; k++)
        {
            int newx = x + dx[k];
            int newy = y + dy[k];
            if (check(newx, newy, n, m, A, vis))
            {
                vis[newx][newy] = true;
                time[newx][newy] = time[x][y] + 1;
                que.push(make_pair(newx, newy));
            }
        }
    }

    int ans = INT_MIN;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (A[i][j] == 1)
            {
                if (vis[i][j] == false)
                {
                    return -1;
                }
                else
                {
                    ans = max(ans, time[i][j]);
                }
            }
        }
    }
    return ans;
}

int main()
{
    return 0;
}