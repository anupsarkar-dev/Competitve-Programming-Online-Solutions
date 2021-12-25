
using System.Collections;

// var nums1 = new int[] { 2,4,6,9,10 };
// var nums2 = new int[] { 1,3,5,7,11,13,16};

// var nums1 = new int[] { 1,2};
// var nums2 = new int[] { 3,4};

// var nums1 = new int[] { 0 ,0};
// var nums2 = new int[] { 0,0};

// var nums1 = new int[] { 1 ,3};
// var nums2 = new int[] { 2};


// var nums1 = new int[] { };
// var nums2 = new int[] {1};


// var nums1 = new int[] {3 };
// var nums2 = new int[] {-2,-1};


// var nums1 = new int[] { };
// var nums2 = new int[] {1,2,3,4};

// var nums1 = new int[] { 1,2};
// var nums2 = new int[] {3};


// var nums1 = new int[] { 4};
// var nums2 = new int[] {1,2,3};

var nums1 = new int[] { 1,1,1};
var nums2 = new int[] {1,1,1};

//  var nums1 = new int[] { 1,2};
//  var nums2 = new int[] {3,4,5};

//  var nums1 = new int[] { 1};
//  var nums2 = new int[] {1};


var result = FindMedianSortedArrays(nums1, nums2);

 
Console.WriteLine(result);


//                    L1    R1
//     nums1: 2   4   6  |  9   10   
//                    L2    R2
//     nums2: 1   3   5  |  7   11   13   16

//     total: 1   2   3   4   5   6  ｜  7   9   10   11   13   16

//     The median is (6 + 7) / 2 = 6.5. 


double FindMedianSortedArrays(int[] nums1, int[] nums2)
{

    var len = nums1.Length + nums2.Length;
 
    var n = (len % 2 == 0) ? (len / 2) - 1 : (len / 2);

    int[] arr  = len <= 2  ?  nums1.Concat(nums2).ToArray() : new int[n + 3];

    var i = 0;
    var count = 0;
    while (count  <= n+1 && len > 2)
    {
        if (i < nums1.Length && i < nums2.Length)
        {
            if (nums1[i] < nums2[i])
            {
                arr[count]=nums1[i];
                count++;
                arr[count]=nums2[i];
                count++;
            }else
            {
                arr[count]=nums2[i];
                count++;
                arr[count]=nums1[i];
                count++;
            }
        }else 
        {
            swap(ref nums1, ref nums2, ref arr,ref i,ref count);
        }
         

        

        i++;

         if(count  == arr.Length - 1 )
            {
                swap(ref nums1, ref nums2, ref arr,ref i,ref count);
            }
        
    }




    Array.Sort(arr);

    return len % 2 != 0 ? arr[len == 0 ? len : (len % 2 == 0) ? (len / 2) - 1 : (len / 2)]
                                        : ((double)(arr[len == 0 ? len : (len % 2 == 0) ? (len / 2) - 1 : (len / 2)]
                                        + arr[len % 2 == 0 ? (len / 2) : (len / 2) + 1])) / 2;
}

 



  void swap(ref int[] nums1, ref int[] nums2,ref int[] arr,ref int i, ref int count)
{
    if (i < nums1.Length)
        {
            
            if (count > 0 && nums1[i]< arr[count-1])
            {
                var temp = arr[count - 1];
                arr[count-1]=nums1[i];
                arr[count] = temp;
                count++;
                 
            }else
            {
                 arr[count]=nums1[i];
                 count++;
            }


        }
        else if (i < nums2.Length)
        {
            if (count>0 && nums2[i]< arr[count-1])
            {
                var temp = arr[count - 1];
                arr[count-1]=nums2[i];
                arr[count] = temp;
                count++;
                 
            }else
            {
                 arr[count]=nums2[i];
                 count++;
            }
        }
}