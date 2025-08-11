// COMPLEMENT PATTERN FRAMEWORK
// Time: O(n²) → O(n) | Space: O(1) → O(n)

public class ComplementPattern {
    
    // 1. IDENTIFY: What are you looking for?
    // 2. CALCULATE: What's the complement?
    // 3. STORE: Keep track of seen elements
    // 4. CHECK: Does complement exist?
    
    // Template:
    public int[] FindComplementingIndices(int[] nums, int target) {
        // Dictionary to store number and its index
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            
            // Check if complement exists in dictionary
            if (numToIndex.ContainsKey(complement)) {
                // Return indices: complement's index and current index
                return new int[] { numToIndex[complement], i };
            }
            
            // Add current number and its index to dictionary
            // Only add if not already present to handle duplicates correctly
            if (!numToIndex.ContainsKey(nums[i])) {
                numToIndex[nums[i]] = i;
            }
        }
        
        // This should never be reached if input guarantees a solution exists
        return new int[0];
    }
}