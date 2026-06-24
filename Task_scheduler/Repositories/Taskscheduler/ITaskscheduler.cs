using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_scheduler.Dto;

namespace Task_scheduler.Repositories.Taskscheduler
{
    public interface ITaskscheduler
    {
        public void ScheduleTask(TaskDto task);
        public void UnScheduleTask(int taskId);
        public void EditScheduledTask(int taskId,TaskDto task);
        public void RemoveScheduledTask(int taskId);
    }
}