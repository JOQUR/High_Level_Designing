#include "LinkedList.h"
#include <malloc.h>

node_t* LinkedList_init(int data)
{
    node_t* next = (node_t*)malloc(sizeof(node_t));
    next->data = data;
    next->head = NULL;

    return next;
}

bool LinkedList_insert(node_t* node, int data)
{
    node_t * current = node;
    while (current->head != NULL) {
        current = current->head;
    }

    current->head = (node_t *) malloc(sizeof(node_t));
    current->head->data = data;
    current->head->head = NULL;
}

bool LinkedList_pop(node_t** head)
{
    node_t * next_node = NULL;

    if (*head == NULL) {
        return false;
    }

    next_node = (*head)->head;
    free(*head);
    *head = next_node;
    return true;
}

bool LinkedList_iterate(node_t* node)
{
    node_t* head = node;
    while(NULL != node->head)
    {
        printf("data: %d\n", head->data);
        head = head->head;

    }
}

bool LinkedList_removeSpecific(node_t* node, int data)
{
    node_t* head = node;

    while(NULL != node->head)
    {
        if(data == head->data)
        {
            node->head = head->head;
            return true;
        }
        else
        {
            head->head = head->head->head;
        }
    }

    return false;
}