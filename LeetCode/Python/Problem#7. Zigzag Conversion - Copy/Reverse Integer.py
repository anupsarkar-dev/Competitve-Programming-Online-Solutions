class Solution:
    def reverse(self, x: int) -> int:
        l = 0
        val = 0
        flag = 1
        if x == 0:
            return x
        else:
            if x>0:
                val = x
                l = len(str(val))
            else:
                val = -1*x
                l = len(str(val))
                flag = 0
        
            count = 10 ** (l-1)

            output = 0
        
            while count>=1:
                output = output + int(val%10*count)
                val=int(val//10)
                count/=10
            
            return (0,(-1*output,output) [flag==1]) [output<2**31 and (output>-1*(2**31))]
        