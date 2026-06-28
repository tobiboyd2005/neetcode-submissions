public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] s_array = s.ToCharArray();
        char[] t_array = t.ToCharArray();


        Array.Sort(t_array);
        Array.Sort(s_array);

        if (s_array.SequenceEqual(t_array)){
            return true;
        } else{
            return false;
        }
    }
}
