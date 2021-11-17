
using LinkedList;


var node0 = new ListNode(2,null);
var node1 = new ListNode(4,node0);
var current = new ListNode(3,node1);


var node2_0 = new ListNode(5,null);
var node2_1 = new ListNode(6,node0);
var current2 = new ListNode(4,node1);
  
var output = AddTwoNumbers(current, current2);

 while(current != null)
 {
    System.Console.WriteLine( current.val );
    current= current.next;
 }
 



ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

    while(current != null)
    {
        System.Console.WriteLine( current.val );
        current= current.next;
    }

        
}
