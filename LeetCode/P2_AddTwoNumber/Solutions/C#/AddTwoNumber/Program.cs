
using LinkedList;


var output = AddTwoNumbers(GETINPUT1(), GETINPUT2());

//RESULT
while (output != null)
{
    System.Console.WriteLine(output.val);
    output = output.next;
}

ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{ 
    ListNode? resultHead  = null;
    ListNode? currentElem = null ;

    int i = 0; var carry = 0; var temp = 0;

    while (l1 != null || l2 != null)
    {
        temp = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry ;
         
        carry = temp > 9 ? 1: 0;

        if (i == 0)
        {
            resultHead = new ListNode(temp > 9 ? temp - 10 : temp);
            currentElem = resultHead;
        }
        else
        {
            currentElem.next = new ListNode(temp > 9 ? temp - 10 : temp);
            currentElem = currentElem.next;
        }

        if( l1 is not null) l1.val = 0;
        if( l2 is not null) l2.val = 0;
        
        l1 =  l1?.next;
        l2 =  l2?.next;

        if(l1 is null && l2 is null && carry > 0)
        {
            currentElem.next = new ListNode(carry);
            currentElem = currentElem.next;
        } 

        i++;
    }
    
    return resultHead;
}



ListNode GETINPUT1()
{
    ListNode head = new ListNode(2);
    ListNode current = head;

    current.next = new ListNode(4);
    current = current.next;

    current.next = new ListNode(3);
    current = current.next;

    return head;
}

ListNode GETINPUT2()
{
    ListNode head2 = new ListNode(5);
    ListNode current2 = head2;

    current2.next = new ListNode(6);
    current2 = current2.next;

    current2.next = new ListNode(4);
    current2 = current2.next;

    return head2;
}