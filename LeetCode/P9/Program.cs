
//Runtime: 28 ms, faster than 99.90% of C# online submissions for Palindrome Number.
//Memory Usage: 29.6 MB, less than 32.71% of C# online submissions for Palindrome Number.
 

 
System.Console.WriteLine(IsPalindrome("122252221"));

 
 
public bool IsPalindrome(int x) {
        
        
       if(x < 0 || (x%10 == 0 && x != 0)) return false;
           
       int revertedNo=0;
       while(x > revertedNo)
        {
            var n= x%10;

            revertedNo= (revertedNo * 10) + (x%10);

            x=x/10;

        }
        
        return (revertedNo == x || x == revertedNo/10) ? true : false;

    }
}

