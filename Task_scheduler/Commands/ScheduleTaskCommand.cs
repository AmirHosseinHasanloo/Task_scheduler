using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_scheduler.Dto;
using Task_scheduler.Repositories.Taskscheduler;

namespace Task_scheduler.Commands
{
    public class ScheduleTaskCommand : ICommandRunner
    {
        private readonly ITaskscheduler taskscheduler;
        private TaskDto taskDto;

        public ScheduleTaskCommand(ITaskscheduler taskscheduler, TaskDto taskDto)
        {
            this.taskscheduler = taskscheduler;
            this.taskDto = taskDto;
        }

        public void Execute()
        {
            if (taskDto != null)
                taskscheduler.ScheduleTask(taskDto);
            System.Console.WriteLine("Please enter a valid data.");
        }
    }
}