#include <stdio.h>
#include <stdbool.h>

typedef struct node_t
{
    int data;
    struct node_t* head;
} node_t;


/*
    @param data to be saved on first item of linked list
    @return returns pointer to a created linked list
*/
node_t* LinkedList_init(int data);

/*
    @param node pointer to a existing linked list
    @param data data to be saved on next element of the list

    @return true if everything went well
*/
bool LinkedList_insert(node_t* node, int data);

/*
    @param head starting point where we will be iterating
    @returns true if everything is ok
*/
bool LinkedList_iterate(node_t* head);

/*
    @param node pointer to pointer to first element of linked list
    @return true if everything is ok
*/
bool LinkedList_pop(node_t** node);

/*
    @param node pointer to a linked lsit
    @param data if exists in list, remove this item
*/
bool LinkedList_removeSpecific(node_t* node, int data);