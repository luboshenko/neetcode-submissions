public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        foreach(var n in nums) {
            if(dict.ContainsKey(n)) {
                dict[n] = dict[n] + 1;
            } else {
                dict[n] = 1;
            }
        }
        var items = dict.ToList();
        items.Sort((i1, i2) => i1.Value.CompareTo(i2.Value));
        var result = new int[k];
        for(int i = 0; i < k; i++) {
            result[i] = items[items.Count - (i+1)].Key;
        }
        return result;
    }
}
