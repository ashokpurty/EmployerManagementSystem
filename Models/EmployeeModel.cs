using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployerManagementSystem.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }

        public string EmployeeCode { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Designation { get; set; }

        public string DepartmentCode { get; set; }

        public string EmployerCode { get; set; }

        public string EmployerId { get; set; }
    }
}