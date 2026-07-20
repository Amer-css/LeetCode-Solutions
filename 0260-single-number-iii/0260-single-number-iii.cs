public class Solution {
    public int[] SingleNumber(int[] nums) 
    {  Dictionary<int, int> counts = new Dictionary<int, int>();
  List<int> Unique = new List<int>();

  foreach (int num in nums)
  {
      if (!counts.ContainsKey(num))
      
          counts[num] = 0;

          counts[num]++;
      
  }

  foreach( var kvp in counts)
  {
       if(kvp.Value == 1)
          Unique.Add(kvp.Key);
  }
  return Unique.ToArray();
        
    }
}