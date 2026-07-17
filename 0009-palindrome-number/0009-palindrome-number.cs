public class Solution {
    public bool IsPalindrome(int x ) 
    {
       if (x < 0) return false;

        Queue<int> queue = new Queue<int>();
        int temp = x;
        
        while (temp > 0) {
            queue.Enqueue(temp % 10);
            temp /= 10;
        }

        Stack<int> stack = new Stack<int>(queue);

        foreach (var item in queue) {
            if (stack.Pop() != item)
                return false;
        }

        return true;

    }
}