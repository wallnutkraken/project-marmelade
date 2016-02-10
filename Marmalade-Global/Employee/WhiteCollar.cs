﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marmalade_Global
{
    class WhiteCollar : IEmployee
    {
        public WhiteCollar(string name,
            string phoneNo, string address, double hourlyWage, string personalID,
            EmployeeStatuses.Department department, EmployeeStatuses.MaritalStatus marity)
        {
            Name = name;
            PhoneNo = phoneNo;
            Address = address;
            HourlyWage = hourlyWage;
            Department = department;
            MaritalStatus = marity;
            PersonalID = personalID;
        }
        public WhiteCollar(): this("","","",0.0,"",0,0)
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


    }
}