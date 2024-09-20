public class Solution {
  public List<List<string>> GroupAnagrams(string[] strs) {
    Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
    foreach (string s in strs) {
      char[] chars = s.ToCharArray();
      Array.Sort(chars);
      string sorted = new string(chars);
      if (!dict.ContainsKey(sorted)) {
        dict[sorted] = new List<string>();
      }
      dict[sorted].Add(s);
    }
    return dict.Values.ToList<List<string>>();
  }
}
