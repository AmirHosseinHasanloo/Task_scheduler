using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_scheduler.Repositories.Taskscheduler
{
    public interface ITaskscheduler
    {
        public void ScheduleTask();
        public void UnScheduleTask();
        public void EditScheduledTask();
        public void RemoveScheduledTask();
    }
}