using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class BlueCollar : IEmployee
    {
        /// <summary>
        /// Creates an employee
        /// </summary>
        /// <param name="name">Full name of the worker</param>
        /// <param name="phoneNo">Mobile/Landline phone number</param>
        /// <param name="address">Primary address</param>
        /// <param name="hourlyWage">Hourly wage as set in contract</param>
        /// <param name="personalID">CPR number or any other form of official identification</param>
        /// <param name="shift">Type of shifts the employee works</param>
        /// <param name="department">Department of the company the employee works for</param>
        /// <param name="marity">Employees marital status</param>
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
        public BlueCollar() : this("", "", "", 0.0, "", 0, 0, 0)
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
            throw new NotImplementedException();
        }

    }
}
