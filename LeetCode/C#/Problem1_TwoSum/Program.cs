
//https://leetcode.com/problems/two-sum/


var arr = new[] { 9, 9, 11, 15 };


var result = TwoSum(arr, 18);



foreach (var item in result)
{
    Console.Write(" " + item);
}



int[] TwoSum(int[] nums, int target)
{
    var hashMap = new Dictionary<int, int?>() { };

    //  if (nums.Length == null && nums.Length < 2)
    //{
    //    return new int[] { -1, -1 };
    //}

    for (int i = 0; i < nums.Length; i++)
    {

        hashMap.Add(i, nums[i]);

    }

    for (int i = 0; i < nums.Length; i++)
    {
        int find = target - nums[i];

        hashMap[i] = null;


        if (hashMap.ContainsValue(find))
        {

            var slice = nums[(i + 1)..];
            var index = Array.IndexOf(slice, find) + (i + 1);

            return new int[] { i, index };
        }


        //if (hashMap.ContainsValue(find))
        //{

        //    var index = Array.IndexOf(nums[(i + 1)..], find) + (i + 1);

        //    return new int[] { i, index };
        //}

    }


    return null;

}

