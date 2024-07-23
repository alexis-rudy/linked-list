public class LinkedList
{
    public Node Head { get; set; }

    // Assuming Node class and other necessary methods are already defined

    public void Reverse()
    {
        Node prev = null;
        Node current = this.Head;
        Node next = null;

        while (current != null)
        {
            next = current.Next; // Store next node
            current.Next = prev; // Reverse current node's pointer
            prev = current; // Move pointers one position ahead
            current = next;
        }
        this.Head = prev; // Update head to the last node which was encountered
    }
}