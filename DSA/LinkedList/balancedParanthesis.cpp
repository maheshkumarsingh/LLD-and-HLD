#include<bits/stdc++.h>
using namespace std;
bool checkBalance(char a, char b)
{
    return ((a=='(' && b == ')')
            || (a=='{' && b == '}')
            || (a=='[' && b == ']'));
}
bool checkBalancedParanthesis(string str)
{
    stack<char> st;
    
    int count=0;
    for(auto &it : str)
    {
        if(it == '(' || it=='{' || it == '[')
            st.push(it);
        else
        {
            count++;
            if(st.empty())
                return false;
            else if(!checkBalance(st.top(),it))
                return false;
            else
                st.pop();
        }
    }
    cout<<count<<endl;
    return st.empty();
}
int main()
{
   system("cls");
   
   string str;
   cin>>str;
   cout<<checkBalancedParanthesis(str);
   return 0;
}