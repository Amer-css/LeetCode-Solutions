public class Solution {
    public int MajorityElement(int[] nums) 
    {
         Dictionary<int ,int> counts = new Dictionary<int, int> ();

        int N = nums.Length / 2;

        foreach(var num in nums)
        {
          if (!counts.ContainsKey(num))
          counts[num] = 0;

         counts[num]++;

        if (counts[num] > N)
         return num;

    }
      return -1;
        
 }
}