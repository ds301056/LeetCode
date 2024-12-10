public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int numSize = nums.Length; // return the size of the nums array

        // loop through the nums array 
        for (int i =0; i < numSize -1; i++){
            // inner loop iterates over elements that come after nums[i]
            for (int j = i + 1; j < numSize; j++){
                // Check if the sum of the current pair (nums[i], nums[j])
                if (nums[i] + nums[j] == target) { return new int[] {i, j}; 
                }
            }
        }
        return new int[0];
        
    }
}