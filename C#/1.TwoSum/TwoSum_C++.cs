class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        //returns the size of nums array
        int n = nums.size();

        //loop through nums array 
        for (int i = 0; i < n -1;  i += 1){

            // Inner loop iterates over elements that come after nums[i]
            for (int j = i + 1; j < n; j++) {  // Loop from j=i+1 to j=n-1

            // Check if the sum of the current pair (nums[i], nums[j])               equals the target
                if (nums[i] + nums[j] == target) {  // If condition is met
                 return {i, j};   // Return a vector containing the indices i and j
                   }
            }
        }
        return {};  // If no solution is found, return an empty vector
    }
};
