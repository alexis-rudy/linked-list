public class ListNode
{
	public int Val { get; set; }
	public ListNode Next { get; set; }

	public ListNode(int val=0, ListNode next=null)
	{
		this.Val = val;
		this.Next = next;
	}
}

public class Solution
{
	public ListNode DeleteDuplicates(ListNode head)
	{
		ListNode current = head;
		while (current != null && current.Next != null)
		{
			if (current.Val == current.Next.Val)
			{
				current.Next = current.Next.Next;
			}
			else
			{
				current = current.Next;
			}
		}
		return head;
	}
}