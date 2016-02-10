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
            string phoneNo, string address, double hourlyWage, string personalID,
            EmployeeStatuses.Shift shift, EmployeeStatuses.Department department,
            EmployeeStatuses.MaritalStatus marity)
        {
            BlueCollar employee = new BlueCollar(name, phoneNo, address, hourlyWage, personalID, shift, department, marity);

            return employee;
        }
        /// <summary>
        /// Creates sales and other white collar employees
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phoneNo"></param>
        /// <param name="address"></param>
        /// <param name="hourlyWage"></param>
        /// <param name="department">Department enum</param>
        /// <param name="marity">Marital status enum</param>
        /// <returns></returns>
        public static WhiteCollar CreateEmployee(string name,
           string phoneNo, string address, double hourlyWage, string personalID,
            EmployeeStatuses.Department department,
           EmployeeStatuses.MaritalStatus marity)
        {
            WhiteCollar employee = new WhiteCollar(name,phoneNo,address,hourlyWage,personalID,department,marity);

            return employee;
        }

    }
}
