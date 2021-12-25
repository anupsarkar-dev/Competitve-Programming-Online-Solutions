
//https://leetcode.com/problems/two-sum/
 

var input = new[] { 2,2,7,11,15}; // target 26
var input2 = new[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };


var output = TwoSum(input2, 11);


foreach (var item in output) Console.Write(" " + item);


int[] TwoSum(int[] nums, int target)
{
    var hashMap = new Dictionary<int,int>() { };

    if (nums.Length < 2)  return new int[] { }; 

    for (int i = 0; i < nums.Length; i++)
    {
        var find = target - nums[i];

        if (hashMap.ContainsKey(find))
        {      
            return new int[] { hashMap[find], i };

        }else
        {
            if(!hashMap.ContainsKey(nums[i]))
            {
                hashMap.Add(nums[i],i);  
            }
                  
        }
    }
      return new int[] { };
}

