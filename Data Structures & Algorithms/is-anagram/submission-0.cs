public class Solution {
    public bool IsAnagram(string s, string t)
    {
        if (s.Length == t.Length)
        {
            char[] s1 = s.ToCharArray();
            char[] t1 = t.ToCharArray();
            Array.Sort(s1);
            Array.Sort(t1);
            if (new string(s1) == new string(t1))
            {
                return true;
            }
        }
        return false;
    }
}