def sort_val(val: list[int]):
    length = len(val)
    
    if length>1:
        middle = length//2
        
        segment_1 = val[:middle]
        segment_2 = val[middle:]
        
        sort_val(segment_1)
        sort_val(segment_2)
        
        s1_id = 0
        s2_id = 0
        dest_id = 0
        
        while s1_id < len(segment_1) and s2_id < len(segment_2):
            if segment_1[s1_id] < segment_2[s2_id]:
                val[dest_id] = segment_1[s1_id]
                s1_id += 1
            else:
                val[dest_id] = segment_2[s2_id]
                s2_id += 1 
            dest_id += 1
         
        while s1_id < len(segment_1):
            val[dest_id] = segment_1[s1_id]
            s1_id += 1
            dest_id += 1
        
        while s2_id < len(segment_2):
            val[dest_id] = segment_2[s2_id]
            s2_id += 1
            dest_id += 1
        
class Solution:
    def findMedianSortedArrays(self, nums1: List[int], nums2: List[int]) -> float: 
        list_all = []
        
        for i in nums1:
            list_all.append(i)
        for i in nums2:
            list_all.append(i)
        
        sort_val(list_all)
        length = len(list_all)
        len_pre = int(length//2-1)
        len_post = int(length//2)

        median = 0
        if length%2 == 0:
            median = (list_all[len_pre]+list_all[len_post])/2
        else:
            median = list_all[len_post]
            
        return median 
    

        