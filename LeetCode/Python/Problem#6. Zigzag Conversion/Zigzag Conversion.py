class Solution:
    def convert(self, s: str, numRows: int) -> str:
        r=0
        c=0
        point=1
        l = [[0 for x in range(len(s))] for y in range(numRows)]
        
        for n in range(len(s)):
            if r>=numRows or (point>1 and point<(numRows)):
                c+=1
                r-=1
                l[r-1][c] = s[n]
                point+=1
                
            elif point > (numRows-1):
                r=1
                l[r][c] = s[n]
                point=1
                
            else:
                l[r][c] = s[n]
                r+=1
                point=1
            
        s=''
        
        for item in l:
            print(item)
        
        i=j=0

        while i<numRows:
            if j>c:
                i+=1
                j=0
                
            else:
                if l[i][j] == 0:
                    j+=1
                    continue
                else:
                    s = s + l[i][j]
                    j+=1
        
        return s            
            
                