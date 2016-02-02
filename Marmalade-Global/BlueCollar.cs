using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class BlueCollar : IEmployee
    {

        public double HourlyWage { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string PersonalID { get; set; }
        public EmployeeEnums.MaritalStatus MaritalStatus { get; set; }
        public EmployeeEnums.Department Department { get; set; }
        public EmployeeEnums.Shift Shift { get; set; }


    /// <summary>
    /// saves blue collar Employee to DB...
    /// </summary>
    /// <param name="employee"></param>
    public static void SaveToDB(BlueCollar employee)
    {
        new NotImplementedException();

    }

    /// <summary>
    /// saves white collar Employee to DB...
    /// </summary>
    /// <param name="employee"></param>
    public static void SaveToDB(WhiteCollar employee)
    {
        new NotImplementedException();
    }

}
}
