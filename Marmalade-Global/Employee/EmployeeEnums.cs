using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    /// <summary>
    /// Class that contains all enums that are related to Employee
    /// </summary>
   class EmployeeStatuses
    {
        /// <summary>
        /// Type of the shift(Day / Evening / Night)
        /// </summary>
        public enum Shift
        {
            Day,
            Evening,
            Night
        }
        /// <summary>
        /// Employees marital status
        /// </summary>
        public enum MaritalStatus
        {
            Single,
            Married,
            Divorced,
            Window,
            ItIsComplicated
        }
        /// <summary>
        /// Department where Employee works in 
        /// </summary>
        public enum Department
        {
            Production,
            Warehouse,
            ProductDev,
            Sales,
            Administration,
            IT,
            Asistant
        }
    }
}
