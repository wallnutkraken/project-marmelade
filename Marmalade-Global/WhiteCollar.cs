using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class WhiteCollar : IEmployee
    {
        public double HourlyWage { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string PersonalID { get; set; }
        public EmployeeEnums.MaritalStatus MaritalStatus { get; set; }
        public EmployeeEnums.Department Department { get; set; }
        public EmployeeEnums.Shift Shift { get; set; }


    }
}
