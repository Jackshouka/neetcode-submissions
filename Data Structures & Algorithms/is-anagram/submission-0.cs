public class Solution {
    public bool IsAnagram(string s, string t) {
       
       if (s.Length != t.Length){
        return false;
       }
       
        var counts = new Dictionary<char, int>();

        foreach (var c in s){
            if (counts.ContainsKey(c)){
                counts[c]++;
            }
            else {
                counts[c] = 1;
            }
        }

        foreach (var d in t){
            if (!counts.ContainsKey(d) || counts[d] == 0){
                return false;
            }
            counts[d]--;
        }

        return true;
    }
}
