#include <iostream>
using namespace std;

static int length = 0;
class node
{
public:
   int data;
   node *next;

   node(int val)
   {
      data = val;
      next = NULL;
   }
};
node *head = NULL;
void insert_node(int position, int value)
{
   node *temp = new node(value);
   if (position == 1)
   {
      temp->next = head;
      head = temp;
   }
   else
   {
      int counter = 1;
      node *curr = head;
      while (counter < position - 1)
      {
         curr = curr->next;
         counter++;
      }
      temp->next = curr->next;
      curr->next = temp;
   }
   length++;
}

void delete_node(int position)
{
   if (position > length)
   {
      return;
   }
   if (position == 1)
   {
      head = head->next;
   }
   else
   {
      int counter = 1;
      node *curr = head;
      while (counter < position - 1)
      {
         counter++;
         curr = curr->next;
      }
      curr->next = curr->next->next;
   }
   length--;
   // @params position, integer
}

void print_ll()
{
   // Output each element followed by a space
   if (length == 0)
   {
      return;
   }
   node *temp = head;
   while (temp->next != NULL)
   {
      cout << temp->data << " ";
      temp = temp->next;
   }
   cout << temp->data;
   return;
}

int main()
{
   return 0;
}