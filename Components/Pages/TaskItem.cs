using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTaskManagementApp.Components.Pages
{
    public class TaskItem
    {
        public string TaskName { get; set; }
        public DateTime Deadline { get; set; }
        public string TimeCommitment { get; set; }
        public string Complexity { get; set; }
    }
}
