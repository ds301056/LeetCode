// The function takes an array of integers 'nums' and a target integer 'target' as input
public int[] TwoSum(int[] nums, int target) {
    // Create a dictionary (hashmap) to store numbers we've seen so far and their indices
    // Key: Number in the array
    // Value: Index of the number
    var seen = new Dictionary<int, int>();

    // Loop through each number in the input array
    for (int i = 0; i < nums.Length; i++) {
        // Calculate the difference (or complement) needed to reach the target
        // If nums[i] is the current number, we need 'target - nums[i]' to complete the sum
        int diff = target - nums[i];

        // Check if the difference is already in the dictionary (i.e., we've seen it before)
        if (seen.ContainsKey(diff)) {
            // If the complement exists in the dictionary, it means we've already seen the number
            // that pairs with nums[i] to make the target. We return their indices.
            return new int[] { seen[diff], i }; // Return the index of the complement and the current index
        }

        // If the complement is not found, add the current number and its index to the dictionary
        // This allows us to look it up later as a potential complement for future numbers
        seen[nums[i]] = i;
    }

    // If no solution is found after the loop, return [-1, -1] to indicate failure
    return new int[] { -1, -1 };
}
