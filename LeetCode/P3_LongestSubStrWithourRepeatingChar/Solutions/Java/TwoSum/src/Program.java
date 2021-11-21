import java.util.HashMap;
import java.util.Map;

public class Program {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		
	
		int[] input = new int[] { 2,2,7,11,15 };
		
		
		int[]  output = twoSum(input, 13);
		
		for (int i = 0; i < output.length; i++)
		{
			
			System.out.println(output[i]);
		}


}
	

	 public static int[] twoSum(int[] nums, int target) {
	        if(nums==null)
	            return new int[0];
	        Map<Integer,Integer> map=new HashMap<>();
	        
	        
	        for(int i=0;i<nums.length;i++) {
	        	
	            Integer idx = map.get(nums[i]);
	            if(idx!=null) {
	                return new int[]{idx,i};
	            }
	            else {
	                    map.put(target-nums[i],i);
	                }
	            }
	         return new int[0];
	        }     

}
