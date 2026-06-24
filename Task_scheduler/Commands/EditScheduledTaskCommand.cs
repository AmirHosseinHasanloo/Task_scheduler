using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_scheduler.Dto;
using Task_scheduler.Repositories.Taskscheduler;

namespace Task_scheduler.Commands
{
    public class EditScheduledTaskCommand : ICommandRunner
    {
        private readonly ITaskscheduler taskscheduler;
        int taskId;
        private TaskDto taskDto;

        public EditScheduledTaskCommand(ITaskscheduler taskscheduler, int taskId, TaskDto taskDto)
        {
            this.taskscheduler = taskscheduler;
            this.taskId = taskId;
            this.taskDto = taskDto;
        }

        public void Execute()
        {
            if (taskId != 0 && taskDto != null)
                taskscheduler.EditScheduledTask(taskId, taskDto);
            System.Console.WriteLine("Please enter a valid data");
        }
    }
}