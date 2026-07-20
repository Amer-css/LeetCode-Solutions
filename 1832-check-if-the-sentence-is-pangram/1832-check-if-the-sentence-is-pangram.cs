public class Solution 
{
    public bool CheckIfPangram(string sentence) 
    {    HashSet<char> alphabetSet = new HashSet<char>();

    foreach(char ch in sentence)
    {
        if(char.IsLetter(ch))
         alphabetSet.Add(char.ToLower(ch));
    }

    return alphabetSet.Count == 26;
   }
        
}
