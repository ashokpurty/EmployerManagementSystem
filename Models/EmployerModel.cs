using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployerManagementSystem.Models
{
    public class EmployerModel
    {
        public int EmployerId { get; set; }

        public string EmployerCode { get; set; }

        public string EmployerName { get; set; }

        public ICollection<EmployeeModel> Employees { get; set; }

    }
}