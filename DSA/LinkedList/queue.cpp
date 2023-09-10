#include<bits/stdc++.h>
using namespace std;

class TreeNode
{
    public:
    int data;
    TreeNode *left;
    TreeNode *right;
    TreeNode(int data)
    {
        this->data = data;
        this->left = NULL;
        this->right = NULL;
    }
};

void Vertical(TreeNode* root)
{
    queue<pair<TreeNode*, int>> que;
    que.push({root,0});
    //int length = que.front();
    pair<TreeNode*, int> p = que.front();
    unordered_map<int,vector<int>> hm;
    vector<int> v = hm[p.second];
    v.push_back(p.first->data);
    hm[p.second] = v;
    int vm = hm[p.second][0];
    cout<<vm<<endl;
}
int main()
{
   system("cls");
   queue<TreeNode*> que;
   TreeNode *root = new TreeNode(10);
   que.push(root);
   que.size();
   que.front();
   pair<int,int> p;
   p.clear();
   return 0;
}