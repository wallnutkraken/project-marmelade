using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class EmployeesScheduleController
    {


        EmployeesSchedule empSchedule = new EmployeesSchedule();


        void test()
        {
            List<Task> allTasks = empSchedule.Tasks;
        }
    }
}
