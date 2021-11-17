def reverse_input(input) -> str:
    return input[::-1]
    # if input == '':
    #     return input
    # else:
    #     return reverse_input(input[1:])+input[0]
    
    
def check_palindrome(check_val,s,length) -> str:
    i = 0
    j = 1

    longest_palindrome = ''
    len_long_pali = len(longest_palindrome)
    
    if length>2:
        while i<length:
            if j>= length:
                i+=1
                j = i+1
            else:
                v = s[check_val[i]:check_val[j]+1]
                v_len = len(v)
                if len(longest_palindrome) < len(v) and v[1]==v[v_len-2]:
                    if reverse_input(v) == v:
                        longest_palindrome = v
                j+=1

    elif length==2:
        var = s[check_val[0]:check_val[1]+1]
        if reverse_input(var) == var and len_long_pali<len(var):
            longest_palindrome = var
    else:
        var = s[check_val[0]]
        if reverse_input(var) == var and len_long_pali<len(var):
            longest_palindrome = var
        longest_palindrome = var
        
    return longest_palindrome

class Solution:
    def longestPalindrome(self, s: str) -> str:
        dic = {}
        i = 0
        longest_palindrome = ''
        
        
        for item in s:
            if item in dic:
                dic[item]+=[i]
                i+=1
            else:
                dic[item]=[i]
                i+=1
        
        for key,item in dic.items():
            longest = ''
            len_1 = len(longest_palindrome)
            len_2 = len(item)
            longest = check_palindrome(item,s,len_2)
            if len(longest) > len_1:
                longest_palindrome = longest
        return longest_palindrome        
            
            