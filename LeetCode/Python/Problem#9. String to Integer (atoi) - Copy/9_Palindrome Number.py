class Solution:
    def isPalindrome(self, x: int) -> bool:
        val=0
        input = x
        
        if input<0:
            return False
        else:
            while input>0:
                val = val*10 + input%10
                input = input//10
        
            return (False,True) [val==x]