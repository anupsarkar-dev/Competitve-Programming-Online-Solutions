class Solution:
    
    def lengthOfLongestSubstring(self, s: str) -> int:
        dic = {}
        for i in range(len(s)):
            dic[i] = s[i]
        
        pre_sub = {}
        sub= ''
        
        for i in range(len(dic)):
            if dic[i] in pre_sub.values():
                for (key,val) in list(pre_sub.items()):
                    if val == dic[i]:
                        key_start=list(pre_sub.keys())[0]
                        while key_start<=key:
                            del pre_sub[key_start]
                            key_start+=1
                
                pre_sub[i] = dic[i]   
                if len(pre_sub) >= len(sub):
                    sub = ''
                    for i in pre_sub.values():
                        sub = sub+str(i)
            else:
                pre_sub[i] = dic[i]
                if len(pre_sub) >= len(sub):
                    sub = ''
                    for i in pre_sub.values(): 
                        sub = sub+str(i)
                    
        return len(sub)