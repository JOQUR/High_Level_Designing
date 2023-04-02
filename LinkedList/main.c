#include <stdio.h>
#include "LinkedList.h"



int main(void)
{
    node_t* node = LinkedList_init(1);
    LinkedList_insert(node, 2);
    LinkedList_insert(node, 666);
    LinkedList_insert(node, 100);
    LinkedList_pop(&node);
    LinkedList_pop(&node);
    LinkedList_removeSpecific(node, 100);
    LinkedList_iterate(node);
    return 0;
}