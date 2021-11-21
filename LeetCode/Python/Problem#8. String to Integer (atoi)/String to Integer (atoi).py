class Solution:
    def myAtoi(self, s: str) -> int:
        len_s = len(s)
        i=0
        isNegative = 0
        count = 0
        output_number = 0
        plusOrMinus = 0
        
        if len_s>200:
            return 0
        else:
            while i <len_s:
                if s[i] == '+':
                    i+=1
                    plusOrMinus+=1
                    if count== 1 or plusOrMinus>1:
                        break
                    else: 
                        isNegative = 0
                        continue
                elif s[i] == '-':
                    i+=1
                    plusOrMinus+=1
                    print('minus')
                    if count==1 or plusOrMinus>1:
                        break
                    else: 
                        isNegative = 1
                        continue
                elif s[i] == ' ':
                    i+=1
                    if count == 1 or plusOrMinus>=1:
                        break
                    else: 
                        continue
                elif s[i] == '.':
                    i+=1
                    break
                elif s[i] >='0' and s[i] <='9':
                    count = 1
                    output_number = output_number*10 + (ord(s[i])-48)
                else:
                    break
                i+=1
                
        output_number = (output_number,-1*output_number) [isNegative == 1] 
        
        thirty_two_bit = (2**31)
        
        if output_number > thirty_two_bit-1:
            return thirty_two_bit-1
        elif output_number < -1*thirty_two_bit:
            return -1*thirty_two_bit
        else: 
            return output_number
        