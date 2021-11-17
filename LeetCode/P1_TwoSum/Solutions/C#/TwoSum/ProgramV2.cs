namespace Problem1_TwoSum
{
    public class ProgramV2
    {
        public static void main()
        {

            var input = new[] { 9, 9, 11, 15 };

            var output = TwoSum(input, 18);

            foreach (var item in output) Console.Write(" " + item);

            int[] TwoSum(int[] nums, int target)
            {

                if (nums.Length < 2)  return new int[] { }; 

                var hashMap = new Dictionary<int, int?>() { };

                //Inserting all the data in HashTable
                for (int i = 0; i < nums.Length; i++) { hashMap.Add(i, nums[i]); }

                for (int i = 0; i < nums.Length; i++)
                {
                    int find = target - nums[i];

                    hashMap[i] = null;

                    if (hashMap.ContainsValue(find))
                    {
                        //searching element from Array by Current index of i
                        var slice = nums[(i + 1)..];

                        var index = Array.IndexOf(slice, find) + (i + 1);

                        return new int[] { i, index };
                    }
                }

                return new int[] { };

            }


        }
    }
}