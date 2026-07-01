public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        List<int> items = new List<int>();

        for (int i = 0; i < nums.Length; i++){
            if (!dict.ContainsKey(nums[i])){
                    dict.Add(nums[i], 1);
                }
            for (int j = i + 1; j < nums.Length; j++){
                if (nums[i] == nums[j]){
                    dict[nums[i]] = dict[nums[i]] + 1;
                }
            }    
        }

        var orderedDict = from entry in dict orderby entry.Value descending select entry;

        foreach (var (name, value) in orderedDict){
            items.Add(name);
        }

        return items[0..k].ToArray();
    }
}
