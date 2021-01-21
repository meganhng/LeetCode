public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        if (nums.Length <= 1){
            return nums.Length;
        }
        
        int maxSum = 0;
        int counter = 0;
        
        for (int i = 0; i<nums.Length; i++){
            if(i ==0){
                counter++;
            }
            else if (nums[i-1]>=nums[i]){
                maxSum = Math.Max(counter, maxSum);
                counter = 1;
            }
            else{
                counter++;
            }
        }
        
        maxSum = Math.Max(counter, maxSum);
        return maxSum;
    }
}