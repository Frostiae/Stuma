using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuma
{
    public class RecurringTask : Task
    {

        /// <summary>
        /// Recurring task constructor, initializes a recurring task that does not have a duration.
        /// </summary>
        public RecurringTask(string taskTitle, string taskDesc, DateTime recurringDate) : 
            base(TaskType.Recurring, taskTitle, taskDesc, recurringDate)
        {
            
        }

        /// <summary>
        /// Recurring task constructor, initializes a task that has a recurring duration.
        /// </summary>
        public RecurringTask(string taskTitle, string taskDesc, DateTime recurringStartDate, DateTime recurringEndDate) :
            base(TaskType.Recurring, taskTitle, taskDesc, recurringStartDate, recurringEndDate)
        {

        }
    }
}
