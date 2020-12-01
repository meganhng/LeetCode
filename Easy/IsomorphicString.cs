public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length == 0 && t.Length == 0){
            return true;
        }
        
        Dictionary <char, char> mappingChars = new Dictionary<char, char>();
        
        for (int i =0; i<s.Length; i++){
            if (mappingChars.ContainsKey(s[i])){
                if (mappingChars[s[i]]!=t[i]){
                    return false;
                }
            }
            else if (mappingChars.ContainsValue(t[i])){
                return false;
            }
            else{
                mappingChars.Add(s[i],t[i]);
            }
        }
        
        return true;
    }
}