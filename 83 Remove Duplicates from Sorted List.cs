// First attempt. Uses recursion to solve, so time/space complexity sucks

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
/*

	Approach: the issue here is that the node cannot see anything but head and next ListNode.
	To handle this, the algorithm uses recursion to move through the next ListNode as a separate ListNode.
	In the case of [1,1,2,3,3], on the first round of the while loop the else is triggered and head
	becomes [1,2,3,3]. On the next round, if is triggered and [2,3,3] is passed to the function.
	Now the loop starts with [2,3,3], but the if is triggered again so [3,3] is passed back to the function.
	Now the loop starts with [3,3] and so the else is triggered making it [3]. The while is broken and
	[3] is passed as the next to [2,3,3] so it becomes [2,3]. The while loop finishes and is passed back to 
	the original as the next, so [1,2,3,3] becomes [1,2,3]

	Improvements: avoid the while loop so it breaks sooner?
	
*/
 
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null) {
            return null;
        }
        while (head.next != null) {
            if (head.val != head.next.val) {
				// keeps head but allows alg to move on to the next nodes
                head.next = DeleteDuplicates(head.next);
                return head;
            }
            else { head = head.next; };
        }
        return head;
    }
}