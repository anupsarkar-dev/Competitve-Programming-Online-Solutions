def binary_search(nums,l,r,val)->int:
    if r>=l:
        mid = l+ (r-l)//2
        if nums[mid] == val:
            return mid
        elif nums[mid] > val:
            return binary_search(nums,l,mid-1,val)
        else:
            return binary_search(nums,mid+1,r,val)
    else:
        return -1
            
        
            
        
        

class Solution:
    def search(self, nums: List[int], target: int) -> int:
        return binary_search(nums,0,len(nums)-1,target)
        