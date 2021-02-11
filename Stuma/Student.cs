using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuma
{
    public class Student
    {
        public string username { get; set; }
        public List<Task> tasks { get; set; }

        public Student(string user)
        {
            username = user;
            tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            // TODO: Update database
            tasks.Add(task);
        }
    }
}
