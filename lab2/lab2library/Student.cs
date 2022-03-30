namespace lab2library
{
    public class Student : Person
    {
        protected string? group;
        protected List<Task>? tasks;

        public string? Group { get { return group; } }

        public Student(string name, int age, string group) : base(name, age)
        {
            tasks = new List<Task>();
            this.group = group;
        }
        public Student(string name, int age, string group, List<Task> tasks) : this(name, age, group)
        {
            this.tasks = tasks;
        }

        public void AddTask(string taskName, TaskStatus taskStatus)
        {
            Task task = new Task(taskName, taskStatus);
            tasks.Add(task);
        }

        public void RemoveTask(int index)
        {
            tasks.RemoveAt(index);
        }

        public void UpdateTask(int index, TaskStatus taskStatus)
        {
            Task task = tasks[index];
            task.Status = taskStatus;
        }

        public string RenderStatus()
        {
            string result = "";
            int i = 1;
            foreach (var task in tasks)
            {
                result += $"{"\t"}{i}. {task}";
                i++;    
            }
            return result;
        }

        public override bool Equals(object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Student s = (Student)obj;
                return base.Equals(obj) && Group == s.Group && SequenceEquals(tasks, s.tasks);
            }
        }

        private bool SequenceEquals(List<Task> a, List<Task> b)
        {
            if (a != null && b != null)
                return a.SequenceEqual(b);
            else
                return false;
        }

        public override string ToString() => "Student: " + base.ToString() + "\n" + $"Group: {Group}\n" + RenderStatus();
    }
}