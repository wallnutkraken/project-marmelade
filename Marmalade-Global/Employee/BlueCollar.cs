using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class BlueCollar : IEmployee
    {
        public BlueCollar(string name,
            string phoneNo, string address, double hourlyWage, string personalID,
            EmployeeStatuses.Shift shift, EmployeeStatuses.Department department,
            EmployeeStatuses.MaritalStatus marity)
        {
            Name = name;
            PhoneNo = phoneNo;
            Address = address;
            HourlyWage = hourlyWage;
            Shift = shift;
            Department = department;
            MaritalStatus = marity;
            PersonalID = personalID;
        }
        public BlueCollar(): this("","","",0.0,"",0,0,0)
        {

        }

        public double HourlyWage { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string PersonalID { get; set; }
        public EmployeeStatuses.MaritalStatus MaritalStatus { get; set; }
        public EmployeeStatuses.Department Department { get; set; }
        public EmployeeStatuses.Shift Shift { get; set; }


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
