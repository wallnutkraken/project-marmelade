using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class EmployeeController
    {
        /// <summary>
        /// Creates production employee
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phoneNo"></param>
        /// <param name="address"></param>
        /// <param name="hourlyWage"></param>
        /// <param name="shift">shift Enum Day / Evening / Nigh</param>
        /// <param name="department">Department enum</param>
        /// <param name="marity">Marital status enum</param>
        /// <returns></returns>
        public static BlueCollar CreateEmployee(string name, 
            string phoneNo, string address, double hourlyWage,
            EmployeeEnums.Shift shift, EmployeeEnums.Department department,
            EmployeeEnums.MaritalStatus marity)
        {
            BlueCollar employee = new BlueCollar();

            employee.Name = name;
            employee.PhoneNo = phoneNo;
            employee.Address = address;
            employee.HourlyWage = hourlyWage;
            employee.Shift = shift;
            employee.Department = department;
            employee.MaritalStatus = marity;

            return employee;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phoneNo"></param>
        /// <param name="address"></param>
        /// <param name="hourlyWage"></param>
        /// <param name="department">Department enum</param>
        /// <param name="marity">Marital status enum</param>
        /// <returns></returns>
        public static WhiteCollar CreateEmployee(string name,
           string phoneNo, string address, double hourlyWage,
            EmployeeEnums.Department department,
           EmployeeEnums.MaritalStatus marity)
        {
            WhiteCollar employee = new WhiteCollar();

            employee.Name = name;
            employee.PhoneNo = phoneNo;
            employee.Address = address;
            employee.HourlyWage = hourlyWage;
            employee.Department = department;
            employee.MaritalStatus = marity;

            return employee;
        }

    }
}
