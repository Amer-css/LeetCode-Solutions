public class Solution {
    public int MissingNumber(int[] nums) 
    {
        HashSet<int> set = new HashSet<int>(nums);

      int n = nums.Length;

      for(int i = 0; i <= n; i++)
       {
        if(!set.Contains(i))
    
          return i;
    
       }
     return -1;
    }
}