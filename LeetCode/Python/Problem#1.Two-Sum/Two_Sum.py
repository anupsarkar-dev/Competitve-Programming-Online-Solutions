class Solution:

    def twoSum(self, nums: List[int], target: int) -> List[int]:
        data = {}
        output = []
       

        for i in range(len(nums)):
            v = target - nums[i]
            if v in data.values(): 
                output.append(nums.index(v))
                output.append(i)
    
            data[i] = nums[i]
            
        return output