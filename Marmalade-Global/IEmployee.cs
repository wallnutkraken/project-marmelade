using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    /// <summary>
    /// Interface that HAS TO BE used while creating any employee class
    /// </summary>
    interface IEmployee
    {
        double HourlyWage { get; set; }
        string Name { get; set; }
        string PhoneNo { get; set; }
        string Address { get; set; }
        string PersonalID { get; set; }
        EmployeeEnums.MaritalStatus MaritalStatus { get; set; }
        EmployeeEnums.Shift Shift { get; set; }
        EmployeeEnums.Department Department { get; set; }

    }
}