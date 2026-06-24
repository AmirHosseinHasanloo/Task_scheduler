using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_scheduler.Entities
{
    public class TaskEntity
    {
        public int TaskId { get; set; }
        public required string TaskName { get; set; }
        public string? Description { get; set; }
        public required string Command { get; set; }
        public DateTimeOffset StartedAt { get; set; }
        public DateTimeOffset EnddedAt { get; set; }
        public bool IsSuccessfull { get; set; } = false;
        public string? Message { get; set; }
        public bool IsUnscheduled { get; set; } = false;
    }
}