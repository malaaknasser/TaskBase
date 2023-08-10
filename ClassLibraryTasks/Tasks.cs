namespace ClassLibraryTasks
{
    public class Tasks
    {
        public string TaskName;
        public string TaskDate;

        public Tasks(string taskName) { 
            TaskName = taskName;
            TaskDate = DateTime.Now.ToString();
        
        }
        public void AddTask(string taskName)
        {
            Tasks tasks = new Tasks(taskName);
        }
    }
}