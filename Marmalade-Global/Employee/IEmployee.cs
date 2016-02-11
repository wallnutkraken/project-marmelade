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
        /// <summary>
        /// Full primary address
        /// </summary>
        string Address { get; set; }
        /// <summary>
        /// CPR number or any other official identification
        /// </summary>
        string PersonalID { get; set; }
        EmployeeStatuses.MaritalStatus MaritalStatus { get; set; }
        EmployeeStatuses.Department Department { get; set; }

    }
}