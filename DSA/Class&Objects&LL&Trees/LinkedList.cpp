#include<bits/stdc++.h>
using namespace std;

class Node
{
    public:
    int data;
    Node *next;

    Node(){data=0; next= NULL;}

    Node(int data)
    {
        this->data = data;
        this->next= NULL;
    }
};


class LinkedList
{
    Node *head;
    public:
    LinkedList()
    {
        head = NULL;
    }

    void insertNode(int,int);
    void insertNode(int);
    void printList();
    void deleteNode(int);
};

void LinkedList::insertNode(int data, int pos)
{
    Node *newNode = new Node(data);
    Node *temp = head;

    if(head==NULL)
    {
        head= newNode;
        return;
    }
    else if(pos<=0)
    {
        newNode->next= head;
        head = newNode;
        return;
    }
    else
    {
        for(int i=1;i<pos;i++)
        {
            if(temp->next==NULL)
                break;
            temp = temp->next;
        }
        newNode->next = temp->next;
        temp->next= newNode;
        return;
    }
}
void LinkedList :: insertNode(int data)
{
    //cout<<"I am here1"<<endl;
    Node *newNode = new Node(data);
    if(head==NULL)
    {
        head = newNode;
        return;
    }
    //cout<<"I am here2"<<endl;

    Node *temp = head;
    while(temp->next!=NULL)
    {
        temp = temp->next;
    }
    temp->next= newNode;
    //cout<<"I am here3"<<endl;
    return;
}
void LinkedList::printList()
{
    if(head==NULL) 
    {
        cout<<"LinkedList is empty :("<<endl;
        return;
    }
    Node *temp = head;
    cout<<"LinkedList: ";
    int len=0;
    while(temp!=NULL)
    {
        cout<<(temp->data)<<"->";
        len++;
        temp = temp->next;
    }
    cout<<"NULL";
    cout<<endl<<"length is: "<<len<<endl;
}
int main()
{
   system("cls");
   LinkedList list;
   list.printList();
   list.insertNode(1,0);
   list.printList();
   list.insertNode(2,1);
   list.printList();
   list.insertNode(3,2);
   list.printList();
   list.insertNode(4,3);
   list.printList();
   list.insertNode(5,4);
   list.printList();
   list.insertNode(200,2);
   list.printList();
   list.insertNode(100);
   list.insertNode(100);
   list.insertNode(100);
   list.printList();
   return 0;
}