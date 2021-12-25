namespace MedianOfTwoArray
{
   
    public class ProgramV2
    {
    
            
        double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            var n1_len = nums1.Length;

            Array.Resize(ref nums1, n1_len + nums2.Length);

            for (int i = n1_len, j = 0; i < nums1.Length; i++, j++)
            {
                nums1[i] = nums2[j];
            }

            

            //nums1 = nums1.Concat(nums2).ToArray();

            Sort(ref nums1);

            var len = nums1.Length <= 1 ?
                                    0 : nums1.Length;

            //var n = len == 0 ? len : (len % 2 == 0) ? (len / 2) - 1 : (len / 2);

            //var n2 = len % 2 == 0 ? (len / 2) : (len / 2) + 1;

            return len % 2 != 0 ? nums1[len == 0 ? len : (len % 2 == 0) ? (len / 2) - 1 : (len / 2)]
                                        : ((double)(nums1[len == 0 ? len : (len % 2 == 0) ? (len / 2) - 1 : (len / 2)]
                                        + nums1[len % 2 == 0 ? (len / 2) : (len / 2) + 1])) / 2;

        }

        static void Sort(ref int[] arr)
                {
                    
                    for (int i = 0; i < arr.Length; i++)
                    {
                        for (int j = 0; j < (arr.Length- i) - 1; j++)
                        {

                            if (arr[j] > arr[j + 1])
                            {
                                var temp = arr[j + 1];

                                arr[j + 1] = arr[j];
                                arr[j] = temp;

                            }

                        }

                    }


                }
        }
   }
