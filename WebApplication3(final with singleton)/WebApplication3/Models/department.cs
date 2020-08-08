using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class department
    {
        string departmentId;
        public string DepartmentId
        {
            get
            { return departmentId; }
            set
            { departmentId = value; }
        }

        string departmentName;
        public string Department_Name
        {
            get
            { return departmentName; }
            set
            { departmentName = value; }
        }

       
    }
}