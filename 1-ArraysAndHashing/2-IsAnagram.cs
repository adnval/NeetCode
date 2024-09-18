public class Solution {
  public bool IsAnagram(string s, string t) {
    if (s.Length != t.Length) {
      return false;
    }
    Dictionary<char, int> dictS = new Dictionary<char, int>();
    Dictionary<char, int> dictT = new Dictionary<char, int>();
    for (int i = 0; i < s.Length; i++) {
      if (dictS.ContainsKey(s[i])) {
        dictS[s[i]]++;
      }
      else {
        dictS.Add(s[i], 1);
      }
      if (dictT.ContainsKey(t[i])) {
        dictT[t[i]]++;
      }
      else {
        dictT.Add(t[i], 1);
      }
    }
    foreach (char c in dictS.Keys) {
      if (!dictT.ContainsKey(c) || dictT[c] != dictS[c]) {
        return false;
      }
    }
    return true;
  }
}
