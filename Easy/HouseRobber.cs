public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 0){
            return 0;
        }
        else if (nums.Length == 1){
            return nums[0];
        }
        else if (nums.Length == 2){
            return Math.Max(nums[0],nums[1]);
        }
        
        int [] amount = new int [nums.Length];
        
        for (int i = 0; i<nums.Length; i++){
            if (i == 0){
                amount[i] = nums[i];
            }
            else if (i ==1){
                amount[i] = Math.Max(nums[0],nums[1]);
            }
            else{
                amount[i] = Math.Max(amount[i-2]+nums[i], amount[i-1]);
            }
        }
        
        return amount[amount.Length -1];
    }
}