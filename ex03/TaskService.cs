namespace ex02
{
    
    public class TaskService : ITaskService
       { 
        static List<Tasks> taskList = new List<Tasks>();
        Tasks t;
        public Tasks createTask(string title, string description, DateTime time, Preference preference)
        {
            t = new Tasks(title, description, time, preference);
            taskList.Add(t);
            return t;
        }

        public bool deleteTask(int id)
        {
            t = taskList.Find(e => e.Id == id);
            if (t == null) return false;
            taskList.Remove(t);
            return true;
        }

        public Tasks updateTask(int id, string title, string description, DateTime time, Preference preference)
        {
            int i = taskList.FindIndex(e => e.Id == id);
            if (i != -1)
            {
                taskList[i].Title = title;
                taskList[i].Description = description;
                taskList[i].Time = time;
                taskList[i].MyPreference = preference;
                return taskList[i];
            }
            else
            return null;
        }
    }
}
