#include <bits/stdc++.h>
using namespace std;

int main()
{
  system("cls");
  vector<int> A = {5, 2, 1, 4};
  int n = A.size();
  vector<vector<int>> ans;
  for (int i = 0; i < n; i++)
  {
    for (int j = i; j < n; j++)
    {
      ans[i][j] = A[j];
    }
  }
  for (int i = 0; i < n; i++)
  {
    for (int j = i; j < n; j++)
    {
      cout<<ans[i][j]<<" ";
    }
  }
  return 0;
}