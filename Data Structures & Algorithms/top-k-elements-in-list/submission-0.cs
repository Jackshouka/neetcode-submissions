public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var set = new Dictionary<int, int>();
        Dictionary<int, int> freqMap = new Dictionary<int, int>();
        foreach (int num in nums) {
            freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach (var pair in freqMap) {
            int freq = pair.Value;
            if (buckets[freq] == null) {
                buckets[freq] = new List<int>();
            }
            buckets[freq].Add(pair.Key);
        }

        List<int> result = new List<int>();
        for (int freq = buckets.Length - 1; freq >= 1 && result.Count < k; freq--) {
            if (buckets[freq] == null) continue;
            foreach (int num in buckets[freq]) {
                result.Add(num);
                if (result.Count == k) break;
            }
        }

        return result.ToArray();
    }
}
