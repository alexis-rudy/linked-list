# Linked Lists
### What are linked lists and why are they important?
Imagine you're trying to manage a collection of items, like a to-do list. You want to be able to easily add, remove, and rearrange tasks. A linked list is a perfect data structure for this kind of dynamic data.

A linked list is similar to an array. They both are structures that hold and remember data for as long as you need. They both store data in a line or linear fashion. They can also both store collections like objects. 

Where they differ is important to understand so you know when to choose one over the other. Arrays are one continuous block of memory that cannot change after compiling. 
Linked lists have nodes for each element and do not require as much memory allowing them to be far more moldable. 

Arrays give you the ability to access individual elements quickly and easily. Linked lists require to iterate through each node before getting to the desired element. The same goes for deleting nodes.

If you have an application that requires fast access to individual elements, an array would be more suited. If your application has common inserting and deleting, a linked list is best. 

### Creating a linked list and adding nodes
```csharp
LinkedList llist = new LinkedList();
llist.Append(1);
llist.Append(2);
llist.Append(3);
llist.PrintList();  
// Output: 1 -> 2 -> 3 -> None
```

### Example: Add to Beginning of Linked List
```csharp
public void AddFirst(int value) {
        // Create new node
        Node newNode = new Node(value);
        // If the list is empty, then point both head and tail to the new node.
        if (_head is null) {
            _head = newNode;
            _tail = newNode;
        }
        // If the list is not empty, then only head will be affected.
        else {
            newNode.Next = _head; // Connect new node to the previous head
            _head.Prev = newNode; // Connect the previous head to the new node
            _head = newNode; // Update the head to point to the new node
        }
}

```

## Deleting a node
```csharp
llist.DeleteNode(2);
llist.PrintList();  // Output: 1 -> 4 -> 3 -> None
```

## Example Problems
Let's try an example.

Your task is to write a function that reverses a linked list.

Try the problem on your own first, then look at my solution if needed.

[Linked List Solution](example_solution.cs)

