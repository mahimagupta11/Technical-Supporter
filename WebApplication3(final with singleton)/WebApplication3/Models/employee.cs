using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class employee
    {
        string _employeeId;
        public string EmployeeId
        {
            get
            { return _employeeId; }
            set
            { _employeeId = value; }
        }

        string _employeeName;
        public string EmployeeName
        {
            get
            { return _employeeName; }
            set
            { _employeeName = value; }
        }

       department _workingDepartment;
        public department Working_Department
        {
            get
            { return _workingDepartment; }
            set
            { _workingDepartment = value; }
        }

        string _domainExpertise;
        public string Domain_Expertise
        {
            get
            { return _domainExpertise; }
            set
            { _domainExpertise = value; }
        }
    }
}