#include<bits/stdc++.h>
using namespace std;
string splitAndReverse(string str)
{
    vector<string> temp;
    int index = str.find(" ");
    int start=0;
    while(index!= string::npos)//Mahesh is a coder
    {
        //cout<<start<<" "<<index<<endl;
        temp.push_back(str.substr(start,index-start));
        //cout<<str.substr(start,index)<<endl;
        start= index+1;
        index = str.find(" ",index+1);
    }
    temp.push_back(str.substr(start,str.length()-start));
    for(auto &it : temp)
        cout<<it<<" ";
    cout<<endl;
    reverse(temp.begin(), temp.end());
    for(auto &it : temp)
        cout<<it<<" ";
    cout<<endl;
    return " ";
}
int main()
{
   system("cls");
   string str = "the sky is blue";
   str.clear();
   cout<<splitAndReverse(str)<<endl;
   reverse(str.begin(), str.end());
   cout<<str<<endl;
   return 0;
}