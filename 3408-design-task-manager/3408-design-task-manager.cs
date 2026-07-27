public class TaskManager {


private class TaskItem : IComparable<TaskItem>
    {
        public int UserId { get; set; }
        public int TaskId { get; set; }
        public int Priority { get; set; }

        public TaskItem(int userId, int taskId, int priority)
        {
            UserId = userId;
            TaskId = taskId;
            Priority = priority;
        }

        public int CompareTo(TaskItem other)
        {
            if (other == null) return 1;

            int pComp = other.Priority.CompareTo(this.Priority);
            if (pComp != 0) return pComp;

            return other.TaskId.CompareTo(this.TaskId);
        }
    }
    private SortedSet<TaskItem> taskSet;
    private Dictionary<int, TaskItem> taskMap;

    public TaskManager(IList<IList<int>> tasks) 
    {
       taskSet = new SortedSet<TaskItem>();
       taskMap = new Dictionary<int, TaskItem>();

        foreach(var taskData in tasks)
        {
           Add(taskData[0], taskData[1], taskData[2]);
        }
    }
    
    public void Add(int userId, int taskId, int priority) 
    {
        TaskItem item = new TaskItem(userId, taskId, priority);
        taskSet.Add(item);
        taskMap[taskId] = item;
    }
    
    public void Edit(int taskId, int newPriority) 
    {
        if (taskMap.TryGetValue(taskId, out TaskItem oldItem))
        {
            taskSet.Remove(oldItem);
            TaskItem newItem = new TaskItem(oldItem.UserId, taskId, newPriority);
            taskSet.Add(newItem);
            taskMap[taskId] = newItem;
        }
    }
    
    public void Rmv(int taskId)
    {
      if (taskMap.TryGetValue(taskId, out TaskItem item))
        {
            taskSet.Remove(item);
            taskMap.Remove(taskId);
        }
        
    }
    
    public int ExecTop() 
    {
       if(taskSet.Count == 0) return -1;

        TaskItem topItem = taskSet.Min;
        int userId = topItem.UserId;

        Rmv(topItem.TaskId);

        return userId;
    }
}

/**
 * Your TaskManager object will be instantiated and called as such:
 * TaskManager obj = new TaskManager(tasks);
 * obj.Add(userId,taskId,priority);
 * obj.Edit(taskId,newPriority);
 * obj.Rmv(taskId);
 * int param_4 = obj.ExecTop();
 */