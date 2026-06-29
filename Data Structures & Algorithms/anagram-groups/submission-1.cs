public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>(); // elements to sorted
        
        foreach ( string s in strs){ 
            char[] chars = s.ToCharArray(); // convert each string to an array
            Array.Sort(chars); // sort each array

            var key = new String(chars); // convert arrays back to string
            if (!dict.ContainsKey(key)){ // if dict does not contain the array create a key vaue pair with an empty list value
                dict[key] = new List<string>();
            }
            dict[key].Add(s); // if key is in the dict add string with same key to value list
        }

        return new List<List<string>>(dict.Values);

    }
}
