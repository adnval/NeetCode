public class Solution {
  public bool hasDuplicate(int[] nums) {
    HashSet<int> set = new HashSet<int>();
    foreach (int n in nums) {
      if (set.Contains(n)) {
        return true;
      }
      set.Add(n);
    }
    return false;
  }
}
