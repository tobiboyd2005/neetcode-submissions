public class Solution {
    public bool hasDuplicate(int[] nums) {
        Array.Sort(nums);
        Dictionary<int, int> result = new Dictionary<int, int>();
        foreach (int i in nums){
            if (result.ContainsKey(i)){
                result[i] = result[i] + 1;
            }else{
                result.Add( i, 1);
            }
        }
        foreach (var (number, frequency) in result){
            if(frequency > 1){
                return true;
            }
        } 
        return false;
    }
}