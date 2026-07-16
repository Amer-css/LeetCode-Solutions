public class MyCircularQueue {

    private int[] queue;
    private int front ;
    private int rear;
    int count;
    public MyCircularQueue(int k) 
    {
        queue = new int[k];
        front = -1;
        rear = -1;
        count = 0;
    }
    
    public bool EnQueue(int value) 
    {
        if(IsFull())
        return false;
       
        if (IsEmpty())
        front = 0;
    
       rear = (rear + 1) % queue.Length;
       
       queue[rear] = value;
       count++;
       return true;    
    }
    
    public bool DeQueue() 
    {
        if (IsEmpty()) return false;

     

       if(front == rear)
       {
         front = -1;
         rear = -1;
       }
       else
       {
        front = (front + 1) % queue.Length;
       }
       count--;
       return true;
    }
    
    public int Front() 
    {
        if (IsEmpty())
        return -1;

       return queue[front];
    }
    
    public int Rear() 
    {
        if (IsEmpty())
        return -1;

        return queue [rear];
    }
    
    public bool IsEmpty() 
    {
       return count == 0;
    }
    
    public bool IsFull() 
    {
        return count == queue.Length;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */