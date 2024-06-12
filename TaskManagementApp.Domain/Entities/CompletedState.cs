using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApp.Domain.Entities
{
    public class CompletedState : ITaskState
    {
        public void CompleteTask(Task task)
        {

        }

        public void RenewTask(Task task)
        {
            task.State = new OpenState();
        }
    }
}
