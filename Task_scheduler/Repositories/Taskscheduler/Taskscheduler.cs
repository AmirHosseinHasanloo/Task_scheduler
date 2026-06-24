using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Task_scheduler.Context;
using Task_scheduler.Dto;

namespace Task_scheduler.Repositories.Taskscheduler
{
    public class Taskscheduler : ITaskscheduler
    {
        private readonly DataBaseContext dbContext;

        public Taskscheduler(DataBaseContext dbContext) =>
        this.dbContext = dbContext;

        public void EditScheduledTask(int taskId, TaskDto task)
        {
            try
            {
                var taskForEdit = dbContext.Task.Where(x => x.TaskId == taskId).FirstOrDefault();

                taskForEdit?.TaskName = task.Name;
                taskForEdit?.Description = task.Description;
                taskForEdit?.StartedAt = task.StartDate;
                taskForEdit?.Command = task.Command;

                dbContext.SaveChanges();
            }
            catch (DbException ex)
            {
                System.Console.WriteLine($"error message: {ex.Message}");
            }
        }

        public void RemoveScheduledTask(int taskId)
        {
            try
            {
                var objectToRemove = dbContext.Task.Where(x => x.TaskId == taskId).First();
                dbContext.Remove(objectToRemove);
                dbContext.SaveChanges();
            }
            catch (DbException ex)
            {
                System.Console.WriteLine($"error message: {ex.Message}");
            }
        }

        public void ScheduleTask(TaskDto task)
        {
            try
            {
                dbContext.Task.Add(new Entities.TaskEntity()
                {
                    TaskName = task.Name,
                    Description = task.Description,
                    Command = task.Command,
                    StartedAt = task.StartDate,

                });
                dbContext.SaveChanges();
            }
            catch (DbException ex)
            {
                System.Console.WriteLine($"error message: {ex.Message}");
            }
        }

        public void UnScheduleTask(int taskId)
        {
            try
            {
                var task = dbContext.Task.Where(x => x.TaskId == taskId).Select(x => x.IsUnscheduled).FirstOrDefault();
                task = true;

                dbContext.SaveChanges();
            }
            catch (DbException ex)
            {
                System.Console.WriteLine($"error message: {ex.Message}");
            }
        }
    }
}