# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        count = 10
        a = l1.val
        b = l2.val
        while l1.next != None:
            a = a + l1.next.val*count
            count = count*10
            l1 = l1.next
            
        count = 10
        while l2.next != None:
            b = b + l2.next.val*count
            count = count*10
            l2 = l2.next
        
        c = a+b
        c_val = c
        l3 = ListNode(c_val%10)
        c_val = int(c_val//10)
        l4 = l3
        while c_val > 0:
            while l4.next != None:
                l4 = l4.next
            l4.next = ListNode(c_val%10)
            c_val = int(c_val//10)
        return l3