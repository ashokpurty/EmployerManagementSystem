using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMSModel = EmployerManagementSystem.Models;

namespace EmployerManagementSystem.Repository
{
    interface IRepositoryService
    {
        List<EMSModel.EmployeeModel> GetAllEmployee();
        List<EMSModel.EmployerModel> GetAllEmployer();
        void AddEmployee(EMSModel.EmployeeModel employeeModel);
        void AddEmployer(EMSModel.EmployerModel employerModel);
        void UpdateEmployee(int id,string value);
        void UpdateEmployer(int id, string value);
    }
}
