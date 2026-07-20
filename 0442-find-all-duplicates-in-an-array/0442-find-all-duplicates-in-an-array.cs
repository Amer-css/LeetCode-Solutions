public class Solution {
    public IList<int> FindDuplicates(int[] nums) 
    {
          Dictionary<int,int> counts = new Dictionary<int, int> ();
         List<int> duplicates = new List<int> ();


        foreach( var num in nums)
       {
           if(counts.ContainsKey(num))
             {
               counts[num]++;
               if (counts[num] == 2)
          
              duplicates.Add(num);
          
           }else
           {
             counts[num] = 1;
           }
       }
         return duplicates;
    }
}