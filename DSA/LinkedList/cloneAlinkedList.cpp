#include<bits/stdc++.h>
using namespace std;
class Node
{
    public:
    int data;
    Node *next;
    Node(){}
    Node(int data,Node *next)
    {
        this->data = data;
        this->next = NULL;
    }
};
Node* copyList(Node *head)
{
    Node *curr = head;
    Node *newList = NULL;
    Node *tail = NULL;

    while(curr!=NULL)
    {
        if(newList==NULL)
        {
            newList = new Node(head->data,NULL);
            tail = newList;
        }
        else
        {
            tail->next = new Node();
            tail = tail->next;
            tail->data = curr->data;
            tail->next = NULL;

        }
        curr = curr->next;
    }
    unordered_map<Node*, Node*> hm;
    hm[newList] = tail->next;
    return newList;
}

int main()
{
   system("cls");
   
   return 0;
}