
//https://leetcode.com/problems/two-sum/


var input = new[] { 2,2,7,11,15};


var output = TwoSum(input, 26);


foreach (var item in output) Console.Write(" " + item);


int[] TwoSum(int[] nums, int target)
{
    var hashMap = new Dictionary<int,int>() { };

    if (nums.Length < 2)  return new int[] { }; 

    for (int i = 0; i < nums.Length; i++)
    {
        int find = target - nums[i];

        if (hashMap.ContainsKey(nums[i]))
        {      
            hashMap.TryGetValue(nums[i],out int  val);
            return new int[] { val, i };

        }else
        {
          hashMap.TryAdd(find,i);         
        }
    }

      return new int[] { };

}

