using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployerManagementSystem.DataAcessLayer;
using EMSModel = EmployerManagementSystem.Models;

namespace EmployerManagementSystem.Repository
{
    public class RepositoryService : IRepositoryService
    {
        public List<EMSModel.EmployeeModel> GetAllEmployee()
        {
            List<EMSModel.EmployeeModel> Employees;
            using (var db = new EMSContextContainer())
            {
                Employees = new List<EMSModel.EmployeeModel>();
                EMSModel.EmployeeModel employee;

                var getAll = db.Employees.ToList();

                foreach (var item in getAll)
                {
                    employee = new EMSModel.EmployeeModel();

                    employee.EmployeeId = item.EmployeeId;
                    employee.FirstName = item.FirstName;
                    employee.EmployerCode = item.EmployeeCode;
                    employee.Designation = item.Designation;
                    employee.DepartmentCode = item.DepartmentCode;
                    employee.EmployeeCode = item.EmployeeCode;
                    employee.EmployeeId = item.EmployeeId;

                    Employees.Add(employee);
                }
            }

            return Employees;
        }

        public List<EMSModel.EmployerModel> GetAllEmployer()
        {
            List<EMSModel.EmployerModel> Employers;
            using (var db = new EMSContextContainer())
            {
                Employers = new List<EMSModel.EmployerModel>();
                EMSModel.EmployerModel employer;

                var getAll = db.Employers.ToList();

                foreach (var item in getAll)
                {
                    employer = new EMSModel.EmployerModel();
                    employer.EmployerId = item.EmployerId;
                    employer.EmployerCode = item.EmployerCode;
                    employer.EmployerName = item.EmployerName;

                    Employers.Add(employer);
                }
            }

            return Employers;
        }

        public void AddEmployee(EMSModel.EmployeeModel employeeModel){
            using (var db = new EMSContextContainer())
            {
                Employee employee = new Employee();
                employee.EmployeeId = employeeModel.EmployeeId;
                employee.FirstName = employeeModel.FirstName;
                employee.Designation = employeeModel.Designation;
                employee.DepartmentCode = employeeModel.DepartmentCode;
                employee.EmployeeCode = employeeModel.EmployeeCode;
                employee.EmployerId = employeeModel.EmployeeId;

                db.Employees.Add(employee);
                db.SaveChanges();
            }
        }

        public void AddEmployer(EMSModel.EmployerModel employerModel){
        }

        public void UpdateEmployee(int id,string value){
            using (var db = new EMSContextContainer())
            {
                Employee updateItem = db.Employees.First(item => item.EmployerId == id);
                if (updateItem != null)
                {
                    updateItem.FirstName = value;
                    db.SaveChanges();
                }
                else
                {
                    //log item not found error
                }

                
            }
        }

        public void UpdateEmployer(int id, string value)
        {
        }
    }
}