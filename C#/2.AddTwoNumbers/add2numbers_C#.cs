/**
 * Definition for singly-linked list.
 * This is a common class used in coding challenges to represent a node in a singly linked list.
 * Each node has two parts:
 * 1. `val` - The value stored in the current node.
 * 2. `next` - A reference (or pointer) to the next node in the list.
 */
public class ListNode {
    public int val; // Field to store the value of the node (e.g., a digit in this problem)
    public ListNode next; // Field to store the reference to the next node in the list

    // Constructor: Used to create a new node
    public ListNode(int val = 0, ListNode next = null) {
        this.val = val; // Initialize the current node's value
        this.next = next; // Initialize the pointer to the next node (null by default)
    }
}

/**
 * This class represents the solution for the problem.
 * It contains methods that implement the logic to solve the coding challenge.
 */
public class Solution {
    // This is the method that solves the "Add Two Numbers" problem.
    // It takes two linked lists (l1 and l2) as input and returns a new linked list representing the sum.
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        // Create a dummy node to simplify result list creation.
        // `result` will be a pointer that we use to build the resulting list.
        ListNode dummyHead = new ListNode(0); // Placeholder node
        ListNode current = dummyHead; // Pointer to build the result linked list
        int sum = 0; // Variable to keep track of the sum (including carry)

        // Loop while there are still nodes in l1 or l2, or there is a carry to process
        while (l1 != null || l2 != null || sum > 0) {
            // Add the value from the current node of l1, if it exists
            if (l1 != null) {
                sum += l1.val; // Add l1's value to the running sum
                l1 = l1.next; // Move to the next node in l1
            }

            // Add the value from the current node of l2, if it exists
            if (l2 != null) {
                sum += l2.val; // Add l2's value to the running sum
                l2 = l2.next; // Move to the next node in l2
            }

            // Use modulus to extract the digit to store in the current node (e.g., sum % 10)
            current.next = new ListNode(sum % 10);

            // Update the carry for the next iteration (e.g., sum divided by 10)
            sum /= 10;

            // Move the `current` pointer forward to the next node
            current = current.next;
        }

        // Return the next node of the dummy head, which is the actual start of the result list
        return dummyHead.next;
    }
}
