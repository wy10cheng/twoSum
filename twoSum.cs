public class Solution {
    public int[] TwoSum(int[] nums, int target) {
                
        var dict = new Dictionary<int, int>();
        
        for (int i = 0, j; i < nums.Length; i++) {
            if (dict.TryGetValue(target - nums[i], out j))
                return new[] {i, j};
            
            dict[nums[i]] = i;
        }
        return new[] {0, 0};             
    }
}
