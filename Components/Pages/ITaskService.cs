using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTaskManagementApp.Components.Pages
{
    public interface ITaskService
    {
        void InsertTask(TaskItem task);
        
    }
}
