public class Solution
{
    public string ReverseVowels(string s)
    {
        int l = 0, r = s.Length - 1;
        HashSet<char> charSet = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        char[] characters = s.ToCharArray();
        //char[] characters = new char[s.Length];
        //for (int i = 0; i < s.Length; i++) characters[i] = s[i];
        char c;
        while (l < r)
        {
            if (charSet.Contains(s[l]))
            {
                while (l < r)
                {
                    if (charSet.Contains(s[r]))
                    {
                        c = characters[r];
                        characters[r] = characters[l];
                        characters[l] = c;
                        r--;
                        l++;
                        break;
                    }
                    r--;
                }
            }
            else
            {
                l++;
            }
        }

        return new string(characters);
    }
}