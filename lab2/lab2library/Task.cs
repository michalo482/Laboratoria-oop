using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2library
{
    public class Task
    {
        private string name = "";
        private TaskStatus status;
        public string Name { get { return name; } set { name = value; } }
        public TaskStatus Status { get { return status; } set { status = value; } } 

        public Task(string name, TaskStatus status)
        {
            Name = name;
            Status = status;
        }

        public override string ToString() => $"{Name} [{Status}] \n";

        public override bool Equals(object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Task task = (Task)obj;
                return Name == task.Name && Status == task.Status;
            }
        }
    }
}
