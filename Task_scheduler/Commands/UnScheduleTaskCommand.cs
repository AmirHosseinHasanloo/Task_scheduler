using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_scheduler.Repositories.Taskscheduler;

namespace Task_scheduler.Commands
{
    public class UnScheduleTaskCommand : ICommandRunner
    {
        private readonly ITaskscheduler taskscheduler;
        int taskId;

        public UnScheduleTaskCommand(ITaskscheduler taskscheduler, int taskId)
        {
            this.taskscheduler = taskscheduler;
            this.taskId = taskId;
        }

        public void Execute()
        {
            if (taskId != 0)
                taskscheduler.UnScheduleTask(taskId);
            System.Console.WriteLine("Please enter a valid data");
        }
    }
}