public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> sets = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++){
            char[] charArray = strs[i].ToCharArray();
            Array.Sort(charArray);
            string signature = new string(charArray);

            if (!sets.ContainsKey(signature)){
                sets.Add(signature, new List<string> { strs[i] });
            } else {
                sets[signature].Add(strs[i]);
            }
        }

        return sets.Values.ToList();
    }
}
