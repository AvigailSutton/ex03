namespace ex02
{
    public interface ITaskService
    {
        Tasks createTask(string title,string description,DateTime time,Preference preference );
        Tasks updateTask(int id,string title, string description, DateTime time, Preference preference);
        bool deleteTask(int id);

    }
}
