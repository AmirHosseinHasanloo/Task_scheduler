using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_scheduler.Dto
{
    public record TaskDto(string Name,string? Description,string Command,DateTimeOffset StartDate);
}