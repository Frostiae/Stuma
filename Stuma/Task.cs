using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuma
{
    public enum TaskType : int
    {
        None = 0,
        DueDate = 1, // Single date, known as the due date
        Regular = 2,
        Recurring = 3 // A task with a duration, such as 05:00 - 06:00
    }
    public class Task
    {
        public TaskType type { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        /// <summary>
        /// Task constructor, initializes a task that does not have a duration.
        /// </summary>
        public Task(TaskType taskType, string taskTitle, string taskDesc, DateTime taskDate)
        {
            type = taskType;
            title = taskTitle;
            description = taskDesc;
            startDate = taskDate;
        }

        /// <summary>
        /// Task constructor, initializes a task that has a duration
        /// </summary>
        public Task(TaskType taskType, string taskTitle, string taskDesc, DateTime taskStartDate, DateTime taskEndDate)
        {
            type = taskType;
            title = taskTitle;
            description = taskDesc;
            startDate = taskStartDate;
            endDate = taskEndDate;
        }
    }
}
