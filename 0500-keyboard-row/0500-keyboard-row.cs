public class Solution {
    public string[] FindWords(string[] words)
    {
            string[] rows = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
Dictionary<char, int> charRow = new Dictionary<char, int>();

for(int i = 0; i  < rows.Length; i++)
{
    foreach( char c in rows[i])
    {
        charRow[c] = i;
    }
}

List<string> result = new List<string>();

foreach(string word in words)
{
    int row = charRow[char.ToLower(word[0])];
    bool IsValid = true;

    foreach (char c in word)
    {
        if (charRow[char.ToLower(c)] != row)
        {
            IsValid = false;
            break;
        }
        
    }
    
    if(IsValid)
        result.Add(word);
}
return result.ToArray();
    }
}